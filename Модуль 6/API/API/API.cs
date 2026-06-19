using System;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace API
{
    public partial class API : Form
    {
        private const string SnilsUrl = "http://localhost:4444/TransferSimulator/snils";
        private string snilsValue;

        public API()
        {
            InitializeComponent();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    string json = client.DownloadString(SnilsUrl);
                    string value = ExtractJsonValue(json, "value");

                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        snilsValue = value;
                        labelGetted.Text = snilsValue;
                        labelGetted.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Не удалось разобрать ответ от сервера",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ExtractJsonValue(string json, string fieldName)
        {
            var pattern = "\"" + Regex.Escape(fieldName) + "\"\\s*:\\s*\"([^\"]+)\"";
            var match = Regex.Match(json, pattern);
            return match.Success ? match.Groups[1].Value : string.Empty;
        }

        private bool CheckFormat(string snils)
        {
            return Regex.IsMatch(snils, @"^\d{3}-\d{3}-\d{3} \d{2}$");
        }

        private bool CheckCharacters(string snils)
        {
            if (snils.Length != 14)
                return false;

            foreach (char c in snils)
            {
                if (!char.IsDigit(c) && c != '-' && c != ' ')
                    return false;
            }

            return true;
        }

        private void buttonSendResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(snilsValue))
            {
                MessageBox.Show("Сначала получите данные",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool formatOk = CheckFormat(snilsValue);
            bool charsOk = CheckCharacters(snilsValue);

            string result1 = formatOk ? "Успешно" : "Не успешно";
            string result2 = charsOk ? "Успешно" : "Не успешно";

            labelResult.Text = "Формат: " + result1 + "\nСимволы: " + result2;
            labelResult.Visible = true;

            try
            {
                string templatePath = Path.GetFullPath(
                    Path.Combine(Application.StartupPath,
                    @"..\..\..\..\Прил_4_В2_КОД 09.02.07-5-2026-М6\ТестКейс.docx"));

                WriteBookmarkValue(templatePath, "СпецСимвол1", result1);
                WriteBookmarkValue(templatePath, "СпецСимвол2", result2);

                MessageBox.Show("Результат записан в ТестКейс.docx",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи в документ: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteBookmarkValue(string docxPath, string bookmarkName, string value)
        {
            XNamespace w = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

            using (var archive = ZipFile.Open(docxPath, ZipArchiveMode.Update))
            {
                var entry = archive.GetEntry("word/document.xml");
                XDocument document;

                using (var reader = new StreamReader(entry.Open(), Encoding.UTF8))
                {
                    document = XDocument.Load(reader);
                }

                var start = document.Descendants(w + "bookmarkStart")
                    .FirstOrDefault(x => (string)x.Attribute(w + "name") == bookmarkName);

                if (start == null)
                    return;

                var bookmarkId = (string)start.Attribute(w + "id");
                var end = document.Descendants(w + "bookmarkEnd")
                    .FirstOrDefault(x => (string)x.Attribute(w + "id") == bookmarkId);

                if (end == null || start.Parent != end.Parent)
                    return;

                var current = start.NextNode;
                while (current != null && current != end)
                {
                    var next = current.NextNode;
                    current.Remove();
                    current = next;
                }

                start.AddAfterSelf(
                    new XElement(w + "r",
                        new XElement(w + "t", value)));

                entry.Delete();
                var newEntry = archive.CreateEntry("word/document.xml");
                using (var writer = new StreamWriter(newEntry.Open(), new UTF8Encoding(false)))
                {
                    document.Save(writer);
                }
            }
        }
    }
}
