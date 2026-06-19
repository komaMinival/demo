using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserManagement
{
    public enum AuthResult
    {
        Success,
        InvalidCredentials,
        Blocked
    }

    public partial class Auth : Form
    {
        public static User CurrentUser { get; private set; }

        public Auth()
        {
            InitializeComponent();
        }

        public AuthResult TryLogin(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                return AuthResult.InvalidCredentials;

            using (var connection = DBConnect.GetConnection())
            {
                connection.Open();

                var command = new SqlCommand(
                    "SELECT id, login, password, role, is_blocked, failed_attempts " +
                    "FROM users WHERE login = @login", connection);
                command.Parameters.AddWithValue("@login", login.Trim());

                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return AuthResult.InvalidCredentials;

                    var user = new User
                    {
                        Id = reader.GetInt32(0),
                        Login = reader.GetString(1),
                        Password = reader.GetString(2),
                        Role = reader.GetString(3),
                        IsBlocked = reader.GetBoolean(4),
                        FailedAttempts = reader.GetInt32(5)
                    };

                    if (user.IsBlocked)
                        return AuthResult.Blocked;

                    if (user.Password != password)
                    {
                        reader.Close();
                        IncrementFailedAttempts(connection, user.Id, user.FailedAttempts);
                        return AuthResult.InvalidCredentials;
                    }

                    reader.Close();
                    ResetFailedAttempts(connection, user.Id);
                    CurrentUser = user;
                    return AuthResult.Success;
                }
            }
        }

        private void IncrementFailedAttempts(SqlConnection connection, int userId, int currentAttempts)
        {
            int newAttempts = currentAttempts + 1;
            bool block = newAttempts >= 3;

            var command = new SqlCommand(
                "UPDATE users SET failed_attempts = @attempts, is_blocked = @blocked WHERE id = @id",
                connection);
            command.Parameters.AddWithValue("@attempts", newAttempts);
            command.Parameters.AddWithValue("@blocked", block);
            command.Parameters.AddWithValue("@id", userId);
            command.ExecuteNonQuery();
        }

        private void ResetFailedAttempts(SqlConnection connection, int userId)
        {
            var command = new SqlCommand(
                "UPDATE users SET failed_attempts = 0 WHERE id = @id", connection);
            command.Parameters.AddWithValue("@id", userId);
            command.ExecuteNonQuery();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните все поля", 
                    "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = TryLogin(textBoxLogin.Text, textBoxPassword.Text);
            switch (result)
            {
                case AuthResult.Success:
                    MessageBox.Show("Вы успешно авторизовались!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (CurrentUser.Role == "Администратор")
                    {
                        var manageUsers = new ManageUsers();
                        this.Hide();
                        manageUsers.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("У вас нет доступа к контенту в данном приложении",
                            "Доступ ограничен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    break;
                case AuthResult.Blocked:
                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору", 
                        "Блокировка аккаунта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
                case AuthResult.InvalidCredentials:
                    MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введённые данные", 
                        "Неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.Text = "";
                    textBoxPassword.Focus();
                    break;
            }
        }
    }
}
