namespace dotATM.Forms
{
    partial class MenuForm
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
            withdrawButton = new Button();
            depositButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(421, 150);
            label1.Name = "label1";
            label1.Size = new Size(335, 81);
            label1.TabIndex = 0;
            label1.Text = "請選擇功能";
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 20F);
            withdrawButton.Location = new Point(139, 433);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(250, 70);
            withdrawButton.TabIndex = 1;
            withdrawButton.Text = "提款";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 20F);
            depositButton.Location = new Point(464, 433);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(250, 70);
            depositButton.TabIndex = 2;
            depositButton.Text = "存款";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 20F);
            logoutButton.Location = new Point(789, 433);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(250, 70);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "登出";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(logoutButton);
            Controls.Add(depositButton);
            Controls.Add(withdrawButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button withdrawButton;
        private Button depositButton;
        private Button logoutButton;
    }
}