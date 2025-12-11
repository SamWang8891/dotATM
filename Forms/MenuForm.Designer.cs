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
            button1 = new Button();
            repayButton = new Button();
            borrowButton = new Button();
            btnForeignWithdraw = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(421, 120);
            label1.Name = "label1";
            label1.Size = new Size(335, 81);
            label1.TabIndex = 0;
            label1.Text = "請選擇功能";
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 20F);
            withdrawButton.Location = new Point(139, 386);
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
            depositButton.Location = new Point(789, 386);
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
            logoutButton.Location = new Point(1052, 561);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(115, 70);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "登出";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(464, 262);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(250, 70);
            button1.TabIndex = 4;
            button1.Text = "轉帳";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // repayButton
            // 
            repayButton.Font = new Font("Segoe UI", 20F);
            repayButton.Location = new Point(631, 510);
            repayButton.Name = "repayButton";
            repayButton.Size = new Size(250, 70);
            repayButton.TabIndex = 3;
            repayButton.Text = "還款";
            repayButton.UseVisualStyleBackColor = true;
            repayButton.Click += repayButton_Click;
            // 
            // borrowButton
            // 
            borrowButton.Font = new Font("Segoe UI", 20F);
            borrowButton.Location = new Point(293, 510);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(250, 70);
            borrowButton.TabIndex = 3;
            borrowButton.Text = "借款";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // btnForeignWithdraw
            // 
            btnForeignWithdraw.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForeignWithdraw.Location = new Point(464, 386);
            btnForeignWithdraw.Margin = new Padding(4, 5, 4, 5);
            btnForeignWithdraw.Name = "btnForeignWithdraw";
            btnForeignWithdraw.Size = new Size(250, 70);
            btnForeignWithdraw.TabIndex = 5;
            btnForeignWithdraw.Text = "外幣提款";
            btnForeignWithdraw.UseVisualStyleBackColor = true;
            btnForeignWithdraw.Click += btnForeignWithdraw_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 643);
            Controls.Add(btnForeignWithdraw);
            Controls.Add(button1);
            Controls.Add(borrowButton);
            Controls.Add(repayButton);
            Controls.Add(logoutButton);
            Controls.Add(depositButton);
            Controls.Add(withdrawButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button button1;
        private Button repayButton;
        private Button borrowButton;
        private Button btnForeignWithdraw;
    }
}