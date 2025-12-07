namespace dotATM.Forms
{
    partial class LoginForm
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
            AccountInput = new TextBox();
            PasswordInput = new TextBox();
            loginBtn = new Button();
            createAccountBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(545, 81);
            label1.TabIndex = 0;
            label1.Text = "請輸入帳號與密碼：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 210);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 81);
            label2.TabIndex = 1;
            label2.Text = "帳號：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 330);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 81);
            label3.TabIndex = 2;
            label3.Text = "密碼：";
            // 
            // AccountInput
            // 
            AccountInput.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountInput.Location = new Point(476, 215);
            AccountInput.Margin = new Padding(4, 5, 4, 5);
            AccountInput.Multiline = true;
            AccountInput.Name = "AccountInput";
            AccountInput.Size = new Size(450, 72);
            AccountInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordInput.Location = new Point(476, 335);
            PasswordInput.Margin = new Padding(4, 5, 4, 5);
            PasswordInput.Multiline = true;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(450, 72);
            PasswordInput.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 20F);
            loginBtn.Location = new Point(639, 480);
            loginBtn.Margin = new Padding(4, 5, 4, 5);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(250, 70);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "登入";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += button1_Click;
            // 
            // createAccountBtn
            // 
            createAccountBtn.Font = new Font("Segoe UI", 20F);
            createAccountBtn.Location = new Point(289, 480);
            createAccountBtn.Margin = new Padding(4, 5, 4, 5);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(250, 70);
            createAccountBtn.TabIndex = 6;
            createAccountBtn.Text = "建立帳戶";
            createAccountBtn.UseVisualStyleBackColor = true;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(createAccountBtn);
            Controls.Add(loginBtn);
            Controls.Add(PasswordInput);
            Controls.Add(AccountInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AccountInput;
        private TextBox PasswordInput;
        private Button loginBtn;
        private Button createAccountBtn;
    }
}