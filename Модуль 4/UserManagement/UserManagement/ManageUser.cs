using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class ManageUser : Form
    {
        private int? EditingUserId;

        public ManageUser()
        {
            InitializeComponent();
            comboBoxRole.SelectedIndex = 1;
            comboBoxBlock.SelectedIndex = 1;
        }

        public void SetEditMode(int id, string login, string password, string role, bool isBlocked)
        {
            EditingUserId = id;
            this.Text = "Изменение пользователя";
            labelHeader.Text = "Изменение пользователя";
            textBoxLogin.Text = login;
            textBoxPassword.Text = password;
            comboBoxRole.SelectedItem = role;
            comboBoxBlock.SelectedIndex = isBlocked ? 0 : 1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxRole.SelectedIndex == -1 || comboBoxBlock.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите роль и статус блокировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;
            string role = comboBoxRole.SelectedItem.ToString();
            bool isBlocked = comboBoxBlock.SelectedIndex == 0;

            using (var connection = DBConnect.GetConnection())
            {
                connection.Open();

                var checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM users WHERE login = @login AND (@id IS NULL OR id != @id)",
                    connection);
                checkCmd.Parameters.AddWithValue("@login", login);
                checkCmd.Parameters.AddWithValue("@id", (object)EditingUserId ?? DBNull.Value);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (EditingUserId.HasValue)
                {
                    var cmd = new SqlCommand(
                        "UPDATE users SET login = @login, password = @password, role = @role, " +
                        "is_blocked = @blocked, failed_attempts = @attempts WHERE id = @id",
                        connection);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@blocked", isBlocked);
                    cmd.Parameters.AddWithValue("@attempts", isBlocked ? 3 : 0);
                    cmd.Parameters.AddWithValue("@id", EditingUserId.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пользователь обновлен",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var cmd = new SqlCommand(
                        "INSERT INTO users (login, password, role, is_blocked, failed_attempts) " +
                        "VALUES (@login, @password, @role, @blocked, 0)",
                        connection);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@blocked", isBlocked);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пользователь создан",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();
        }
    }
}
