namespace UserManagement
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelAuth = new System.Windows.Forms.TableLayoutPanel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAuthHead = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelAuth, 1, 1);
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(540, 320);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelAuth
            // 
            this.tableLayoutPanelAuth.ColumnCount = 2;
            this.tableLayoutPanelAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanelAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanelAuth.Controls.Add(this.labelPassword, 0, 2);
            this.tableLayoutPanelAuth.Controls.Add(this.labelAuthHead, 0, 0);
            this.tableLayoutPanelAuth.Controls.Add(this.labelLogin, 0, 1);
            this.tableLayoutPanelAuth.Controls.Add(this.textBoxLogin, 1, 1);
            this.tableLayoutPanelAuth.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanelAuth.Controls.Add(this.buttonAuth, 1, 3);
            this.tableLayoutPanelAuth.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAuth.Location = new System.Drawing.Point(67, 41);
            this.tableLayoutPanelAuth.Name = "tableLayoutPanelAuth";
            this.tableLayoutPanelAuth.RowCount = 4;
            this.tableLayoutPanelAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanelAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanelAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanelAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanelAuth.Size = new System.Drawing.Size(404, 237);
            this.tableLayoutPanelAuth.TabIndex = 0;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.Location = new System.Drawing.Point(3, 123);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(147, 56);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuthHead
            // 
            this.labelAuthHead.AutoSize = true;
            this.tableLayoutPanelAuth.SetColumnSpan(this.labelAuthHead, 2);
            this.labelAuthHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAuthHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAuthHead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAuthHead.Location = new System.Drawing.Point(3, 0);
            this.labelAuthHead.Name = "labelAuthHead";
            this.labelAuthHead.Size = new System.Drawing.Size(398, 66);
            this.labelAuthHead.TabIndex = 0;
            this.labelAuthHead.Text = "Доступ к системе";
            this.labelAuthHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogin.Location = new System.Drawing.Point(3, 66);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(147, 57);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин:";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.Location = new System.Drawing.Point(156, 80);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(245, 26);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(156, 138);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(245, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonAuth
            // 
            this.buttonAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAuth.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.buttonAuth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAuth.Location = new System.Drawing.Point(256, 182);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(145, 36);
            this.buttonAuth.TabIndex = 3;
            this.buttonAuth.Text = "Авторизоваться";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 359);
            this.MinimumSize = new System.Drawing.Size(556, 359);
            this.Name = "Auth";
            this.Text = "Панель доступа";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelAuth.ResumeLayout(false);
            this.tableLayoutPanelAuth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAuth;
        private System.Windows.Forms.Label labelAuthHead;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAuth;
    }
}

