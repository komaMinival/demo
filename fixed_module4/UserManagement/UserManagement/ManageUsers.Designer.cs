namespace UserManagement
{
    partial class ManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUserManageAll = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanelManageUser = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelUserManageAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tableLayoutPanelManageUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelUserManageAll, 1, 1);
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(920, 520);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutPanelUserManageAll
            // 
            this.tableLayoutPanelUserManageAll.ColumnCount = 1;
            this.tableLayoutPanelUserManageAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserManageAll.Controls.Add(this.dataGridViewUsers, 0, 1);
            this.tableLayoutPanelUserManageAll.Controls.Add(this.labelHeader, 0, 0);
            this.tableLayoutPanelUserManageAll.Controls.Add(this.tableLayoutPanelManageUser, 0, 2);
            this.tableLayoutPanelUserManageAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUserManageAll.Location = new System.Drawing.Point(39, 23);
            this.tableLayoutPanelUserManageAll.Name = "tableLayoutPanelUserManageAll";
            this.tableLayoutPanelUserManageAll.RowCount = 3;
            this.tableLayoutPanelUserManageAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelUserManageAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserManageAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanelUserManageAll.Size = new System.Drawing.Size(840, 472);
            this.tableLayoutPanelUserManageAll.TabIndex = 0;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 47);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(834, 364);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Location = new System.Drawing.Point(3, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(834, 44);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Управление пользователями";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelManageUser
            // 
            this.tableLayoutPanelManageUser.ColumnCount = 3;
            this.tableLayoutPanelManageUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelManageUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelManageUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelManageUser.Controls.Add(this.buttonDelete, 2, 0);
            this.tableLayoutPanelManageUser.Controls.Add(this.buttonUserEdit, 1, 0);
            this.tableLayoutPanelManageUser.Controls.Add(this.buttonAddNewUser, 0, 0);
            this.tableLayoutPanelManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelManageUser.Location = new System.Drawing.Point(3, 417);
            this.tableLayoutPanelManageUser.Name = "tableLayoutPanelManageUser";
            this.tableLayoutPanelManageUser.RowCount = 1;
            this.tableLayoutPanelManageUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelManageUser.Size = new System.Drawing.Size(834, 52);
            this.tableLayoutPanelManageUser.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(560, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(271, 46);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить пользователя";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUserEdit.Enabled = false;
            this.buttonUserEdit.Location = new System.Drawing.Point(286, 3);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(268, 46);
            this.buttonUserEdit.TabIndex = 2;
            this.buttonUserEdit.Text = "Изменить пользователя";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddNewUser.Location = new System.Drawing.Point(3, 3);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(277, 46);
            this.buttonAddNewUser.TabIndex = 1;
            this.buttonAddNewUser.Text = "Добавить нового пользователя";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximumSize = new System.Drawing.Size(1200, 760);
            this.MinimumSize = new System.Drawing.Size(936, 559);
            this.Name = "ManageUsers";
            this.Text = "Управление пользователями";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelUserManageAll.ResumeLayout(false);
            this.tableLayoutPanelUserManageAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tableLayoutPanelManageUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserManageAll;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelManageUser;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUserEdit;
        private System.Windows.Forms.Button buttonAddNewUser;
    }
}
