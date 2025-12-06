namespace dotATM.Forms
{
    partial class CreateAccountForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            accountTextBox = new TextBox();
            passwordTextBox = new TextBox();
            recheckTextBox = new TextBox();
            button_back = new Button();
            button_create_account = new Button();
            label4 = new Label();
            label_warning = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 53);
            label1.Name = "label1";
            label1.Size = new Size(84, 45);
            label1.TabIndex = 0;
            label1.Text = "帳號";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 180);
            label2.Name = "label2";
            label2.Size = new Size(84, 45);
            label2.TabIndex = 1;
            label2.Text = "密碼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 249);
            label3.Name = "label3";
            label3.Size = new Size(148, 45);
            label3.TabIndex = 2;
            label3.Text = "確認密碼";
            // 
            // accountTextBox
            // 
            accountTextBox.BorderStyle = BorderStyle.FixedSingle;
            accountTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountTextBox.Location = new Point(269, 53);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(373, 45);
            accountTextBox.TabIndex = 3;
            accountTextBox.KeyPress += keyPass_process;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(269, 180);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(373, 45);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.KeyPress += keyPass_process;
            // 
            // recheckTextBox
            // 
            recheckTextBox.BorderStyle = BorderStyle.FixedSingle;
            recheckTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recheckTextBox.Location = new Point(269, 249);
            recheckTextBox.Name = "recheckTextBox";
            recheckTextBox.PasswordChar = '*';
            recheckTextBox.Size = new Size(373, 45);
            recheckTextBox.TabIndex = 5;
            recheckTextBox.KeyPress += keyPass_process;
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_back.Location = new Point(88, 375);
            button_back.Name = "button_back";
            button_back.Size = new Size(156, 65);
            button_back.TabIndex = 6;
            button_back.Text = "返回";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_create_account
            // 
            button_create_account.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_create_account.Location = new Point(269, 375);
            button_create_account.Name = "button_create_account";
            button_create_account.Size = new Size(373, 65);
            button_create_account.TabIndex = 7;
            button_create_account.Text = "創建帳號";
            button_create_account.UseVisualStyleBackColor = true;
            button_create_account.Click += button_create_account_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(107, 115);
            label4.Name = "label4";
            label4.Size = new Size(524, 32);
            label4.TabIndex = 8;
            label4.Text = "密碼必須包含大小寫英文與數字 長度 6 個字元";
            // 
            // label_warning
            // 
            label_warning.AutoSize = true;
            label_warning.BackColor = SystemColors.Control;
            label_warning.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_warning.ForeColor = Color.FromArgb(192, 0, 0);
            label_warning.Location = new Point(88, 317);
            label_warning.Name = "label_warning";
            label_warning.Size = new Size(0, 32);
            label_warning.TabIndex = 9;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(label_warning);
            Controls.Add(label4);
            Controls.Add(button_create_account);
            Controls.Add(button_back);
            Controls.Add(recheckTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(accountTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "創建帳號";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox accountTextBox;
        private TextBox passwordTextBox;
        private TextBox recheckTextBox;
        private Button button_back;
        private Button button_create_account;
        private Label label4;
        private Label label_warning;
    }
}