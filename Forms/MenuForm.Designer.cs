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
            label1.Location = new Point(328, 113);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "請選擇功能";
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(174, 265);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(112, 34);
            withdrawButton.TabIndex = 1;
            withdrawButton.Text = "提款";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(412, 265);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(112, 34);
            depositButton.TabIndex = 2;
            depositButton.Text = "存款";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(586, 254);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(112, 34);
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