using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (!IsDesignerMode())
                LoadUsers();
        }

        private bool IsDesignerMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;
        }

        public void LoadUsers()
        {
            using (var connection = DBConnect.GetConnection())
            {
                connection.Open();
                var adapter = new SqlDataAdapter(
                    "SELECT id, login, password, role, is_blocked FROM users",
                    connection);
                var table = new DataTable();
                adapter.Fill(table);

                dataGridViewUsers.DataSource = table;
                dataGridViewUsers.Columns["id"].Visible = false;
                dataGridViewUsers.Columns["password"].Visible = false;
                dataGridViewUsers.Columns["login"].HeaderText = "Логин";
                dataGridViewUsers.Columns["role"].HeaderText = "Роль";
                dataGridViewUsers.Columns["is_blocked"].HeaderText = "Блокировка";
                dataGridViewUsers.Font = new Font("Microsoft Sans Serif", 10F);
            }
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dataGridViewUsers.SelectedRows.Count > 0;
            buttonDelete.Enabled = hasSelection;
            buttonUserEdit.Enabled = hasSelection;
        }

        private void buttonUserEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
                return;

            var row = dataGridViewUsers.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id"].Value);
            string login = row.Cells["login"].Value.ToString();
            string password = row.Cells["password"].Value.ToString();
            string role = row.Cells["role"].Value.ToString();
            bool isBlocked = Convert.ToBoolean(row.Cells["is_blocked"].Value);

            var form = new ManageUser();
            form.SetEditMode(id, login, password, role, isBlocked);
            form.ShowDialog();
            LoadUsers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new ManageUser();
            form.ShowDialog();
            LoadUsers();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
                return;

            var selectedRow = dataGridViewUsers.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["id"].Value);
            string login = selectedRow.Cells["login"].Value.ToString();

            var confirm = MessageBox.Show(
                $"Вы уверены, что хотите удалить пользователя \"{login}\"?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using (var connection = DBConnect.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM users WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", userId);
                command.ExecuteNonQuery();
            }

            LoadUsers();
        }
    }
}
