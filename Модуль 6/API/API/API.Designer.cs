namespace API
{
    partial class API
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSendResult = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.labelGetted = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSendResult, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonGet, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelGetted, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelResult, 1, 2);
            this.tableLayoutPanel1.SetColumnSpan(this.labelGetted, 2);
            this.tableLayoutPanel1.SetColumnSpan(this.labelResult, 2);
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonSendResult
            // 
            this.buttonSendResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendResult.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSendResult.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.buttonSendResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSendResult.Location = new System.Drawing.Point(282, 278);
            this.buttonSendResult.Name = "buttonSendResult";
            this.buttonSendResult.Size = new System.Drawing.Size(227, 28);
            this.buttonSendResult.TabIndex = 9;
            this.buttonSendResult.Text = "Отправить результат теста";
            this.buttonSendResult.UseVisualStyleBackColor = true;
            this.buttonSendResult.Click += new System.EventHandler(this.buttonSendResult_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGet.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGet.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.buttonGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGet.Location = new System.Drawing.Point(49, 278);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(227, 28);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "Получить данные";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // labelGetted
            // 
            this.labelGetted.AutoSize = true;
            this.labelGetted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGetted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGetted.Location = new System.Drawing.Point(49, 32);
            this.labelGetted.Name = "labelGetted";
            this.labelGetted.Size = new System.Drawing.Size(460, 112);
            this.labelGetted.TabIndex = 1;
            this.labelGetted.Text = "номер";
            this.labelGetted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGetted.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelResult.Location = new System.Drawing.Point(49, 144);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(460, 112);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "результат";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Visible = false;
            // 
            // API
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "API";
            this.Text = "Проверка СНИЛС";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Label labelGetted;
        private System.Windows.Forms.Button buttonSendResult;
        private System.Windows.Forms.Label labelResult;
    }
}

