namespace dotATM.Forms
{
    partial class RepayForm
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
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(464, 300);
            button1.Name = "button1";
            button1.Size = new Size(166, 51);
            button1.TabIndex = 0;
            button1.Text = "還款";
            button1.UseVisualStyleBackColor = true;
            button1.Click += repayButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(192, 201);
            label2.Name = "label2";
            label2.Size = new Size(135, 37);
            label2.TabIndex = 2;
            label2.Text = "還款金額:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(356, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 43);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 121);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 2;
            label1.Text = "欠款金額:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(356, 121);
            label3.Name = "label3";
            label3.Size = new Size(0, 37);
            label3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(244, 300);
            button2.Name = "button2";
            button2.Size = new Size(166, 51);
            button2.TabIndex = 0;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnReturn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(192, 54);
            label4.Name = "label4";
            label4.Size = new Size(135, 37);
            label4.TabIndex = 2;
            label4.Text = "帳戶餘額:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(356, 54);
            label5.Name = "label5";
            label5.Size = new Size(0, 37);
            label5.TabIndex = 2;
            // 
            // RepayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 386);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RepayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RepayForm";
            Load += ShowBalance;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
    }
}