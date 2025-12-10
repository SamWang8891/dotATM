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
            repayButton = new Button();
            borrowButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(295, 90);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 54);
            label1.TabIndex = 0;
            label1.Text = "請選擇功能";
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 20F);
            withdrawButton.Location = new Point(96, 188);
            withdrawButton.Margin = new Padding(2);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(175, 42);
            withdrawButton.TabIndex = 1;
            withdrawButton.Text = "提款";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 20F);
            depositButton.Location = new Point(328, 188);
            depositButton.Margin = new Padding(2);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(175, 42);
            depositButton.TabIndex = 2;
            depositButton.Text = "存款";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 20F);
            logoutButton.Location = new Point(554, 188);
            logoutButton.Margin = new Padding(2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(175, 42);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "登出";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // repayButton
            // 
            repayButton.Font = new Font("Segoe UI", 20F);
            repayButton.Location = new Point(442, 272);
            repayButton.Margin = new Padding(2);
            repayButton.Name = "repayButton";
            repayButton.Size = new Size(175, 42);
            repayButton.TabIndex = 3;
            repayButton.Text = "還款";
            repayButton.UseVisualStyleBackColor = true;
            repayButton.Click += repayButton_Click;
            // 
            // borrowButton
            // 
            borrowButton.Font = new Font("Segoe UI", 20F);
            borrowButton.Location = new Point(205, 272);
            borrowButton.Margin = new Padding(2);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(175, 42);
            borrowButton.TabIndex = 3;
            borrowButton.Text = "借款";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 386);
            Controls.Add(borrowButton);
            Controls.Add(repayButton);
            Controls.Add(logoutButton);
            Controls.Add(depositButton);
            Controls.Add(withdrawButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "功能選擇";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button withdrawButton;
        private Button depositButton;
        private Button logoutButton;
        private Button repayButton;
        private Button borrowButton;
    }
}