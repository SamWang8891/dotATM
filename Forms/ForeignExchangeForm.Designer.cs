namespace dotATM.Forms
{
    partial class ForeignExchangeForm
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
            button_jp = new Button();
            pictureBox_jp = new PictureBox();
            pictureBox_us = new PictureBox();
            button_us = new Button();
            pictureBox_eu = new PictureBox();
            button_eu = new Button();
            pictureBox_cn = new PictureBox();
            button_cn = new Button();
            label_current_rate = new Label();
            button_back = new Button();
            label_currency_name = new Label();
            label1 = new Label();
            label2 = new Label();
            label_exchange_rate = new Label();
            label_reverse_rate = new Label();
            groupBox1 = new GroupBox();
            textBox_target = new TextBox();
            btnOption1 = new Button();
            btnOption2 = new Button();
            btnOption3 = new Button();
            btnOption4 = new Button();
            label3 = new Label();
            label_deduct = new Label();
            button_withdraw = new Button();
            button_clear = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_jp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_us).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cn).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button_jp
            // 
            button_jp.Font = new Font("Segoe UI", 20F);
            button_jp.Location = new Point(72, 69);
            button_jp.Name = "button_jp";
            button_jp.Size = new Size(390, 100);
            button_jp.TabIndex = 0;
            button_jp.Text = "日圓 JPY ";
            button_jp.TextAlign = ContentAlignment.MiddleRight;
            button_jp.UseVisualStyleBackColor = true;
            button_jp.Click += button_jp_Click;
            // 
            // pictureBox_jp
            // 
            pictureBox_jp.BackColor = Color.Transparent;
            pictureBox_jp.Image = Properties.Resources.flag_jp;
            pictureBox_jp.Location = new Point(97, 88);
            pictureBox_jp.Name = "pictureBox_jp";
            pictureBox_jp.Size = new Size(96, 66);
            pictureBox_jp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_jp.TabIndex = 1;
            pictureBox_jp.TabStop = false;
            // 
            // pictureBox_us
            // 
            pictureBox_us.BackColor = Color.Transparent;
            pictureBox_us.Image = Properties.Resources.flag_us;
            pictureBox_us.Location = new Point(97, 300);
            pictureBox_us.Name = "pictureBox_us";
            pictureBox_us.Size = new Size(96, 66);
            pictureBox_us.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_us.TabIndex = 3;
            pictureBox_us.TabStop = false;
            // 
            // button_us
            // 
            button_us.Font = new Font("Segoe UI", 20F);
            button_us.Location = new Point(72, 281);
            button_us.Name = "button_us";
            button_us.Size = new Size(390, 100);
            button_us.TabIndex = 2;
            button_us.Text = "美元 USD ";
            button_us.TextAlign = ContentAlignment.MiddleRight;
            button_us.UseVisualStyleBackColor = true;
            button_us.Click += button_us_Click;
            // 
            // pictureBox_eu
            // 
            pictureBox_eu.BackColor = Color.Transparent;
            pictureBox_eu.Image = Properties.Resources.flag_eu;
            pictureBox_eu.Location = new Point(97, 406);
            pictureBox_eu.Name = "pictureBox_eu";
            pictureBox_eu.Size = new Size(96, 66);
            pictureBox_eu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_eu.TabIndex = 5;
            pictureBox_eu.TabStop = false;
            // 
            // button_eu
            // 
            button_eu.Font = new Font("Segoe UI", 20F);
            button_eu.Location = new Point(72, 387);
            button_eu.Name = "button_eu";
            button_eu.Size = new Size(390, 100);
            button_eu.TabIndex = 4;
            button_eu.Text = "歐元 EUR ";
            button_eu.TextAlign = ContentAlignment.MiddleRight;
            button_eu.UseVisualStyleBackColor = true;
            button_eu.Click += button_eu_Click;
            // 
            // pictureBox_cn
            // 
            pictureBox_cn.BackColor = Color.Transparent;
            pictureBox_cn.Image = Properties.Resources.flag_cn;
            pictureBox_cn.Location = new Point(97, 194);
            pictureBox_cn.Name = "pictureBox_cn";
            pictureBox_cn.Size = new Size(96, 66);
            pictureBox_cn.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_cn.TabIndex = 7;
            pictureBox_cn.TabStop = false;
            // 
            // button_cn
            // 
            button_cn.Font = new Font("Segoe UI", 20F);
            button_cn.Location = new Point(72, 175);
            button_cn.Name = "button_cn";
            button_cn.Size = new Size(390, 100);
            button_cn.TabIndex = 6;
            button_cn.Text = "人民幣 CNY ";
            button_cn.TextAlign = ContentAlignment.MiddleRight;
            button_cn.UseVisualStyleBackColor = true;
            button_cn.Click += button_cn_Click;
            // 
            // label_current_rate
            // 
            label_current_rate.AutoSize = true;
            label_current_rate.Font = new Font("Segoe UI", 20F);
            label_current_rate.Location = new Point(528, 43);
            label_current_rate.Name = "label_current_rate";
            label_current_rate.Size = new Size(191, 54);
            label_current_rate.TabIndex = 8;
            label_current_rate.Text = "目前匯率";
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 20F);
            button_back.Location = new Point(72, 506);
            button_back.Name = "button_back";
            button_back.Size = new Size(390, 74);
            button_back.TabIndex = 9;
            button_back.Text = "返回";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label_currency_name
            // 
            label_currency_name.Font = new Font("Segoe UI", 18F);
            label_currency_name.Location = new Point(754, 48);
            label_currency_name.Name = "label_currency_name";
            label_currency_name.Size = new Size(431, 44);
            label_currency_name.TabIndex = 10;
            label_currency_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(55, 24);
            label1.Name = "label1";
            label1.Size = new Size(149, 54);
            label1.TabIndex = 11;
            label1.Text = "主匯率";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(13, 78);
            label2.Name = "label2";
            label2.Size = new Size(191, 54);
            label2.TabIndex = 12;
            label2.Text = "反向匯率";
            // 
            // label_exchange_rate
            // 
            label_exchange_rate.Font = new Font("Segoe UI", 18F);
            label_exchange_rate.Location = new Point(239, 29);
            label_exchange_rate.Name = "label_exchange_rate";
            label_exchange_rate.Size = new Size(431, 44);
            label_exchange_rate.TabIndex = 13;
            label_exchange_rate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_reverse_rate
            // 
            label_reverse_rate.Font = new Font("Segoe UI", 18F);
            label_reverse_rate.Location = new Point(239, 84);
            label_reverse_rate.Name = "label_reverse_rate";
            label_reverse_rate.Size = new Size(431, 44);
            label_reverse_rate.TabIndex = 14;
            label_reverse_rate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(38, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 478);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "匯率選擇";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox_target
            // 
            textBox_target.Font = new Font("Segoe UI", 20F);
            textBox_target.Location = new Point(13, 151);
            textBox_target.Name = "textBox_target";
            textBox_target.Size = new Size(714, 61);
            textBox_target.TabIndex = 16;
            textBox_target.TextChanged += textBox_target_TextChanged;
            textBox_target.KeyPress += textBox_target_KeyPress;
            // 
            // btnOption1
            // 
            btnOption1.Font = new Font("Segoe UI", 12F);
            btnOption1.Location = new Point(13, 229);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(287, 49);
            btnOption1.TabIndex = 17;
            btnOption1.UseVisualStyleBackColor = true;
            btnOption1.Click += btnQuickAmount_Click;
            // 
            // btnOption2
            // 
            btnOption2.Font = new Font("Segoe UI", 12F);
            btnOption2.Location = new Point(306, 229);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(287, 49);
            btnOption2.TabIndex = 18;
            btnOption2.UseVisualStyleBackColor = true;
            btnOption2.Click += btnQuickAmount_Click;
            // 
            // btnOption3
            // 
            btnOption3.Font = new Font("Segoe UI", 12F);
            btnOption3.Location = new Point(13, 284);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(287, 49);
            btnOption3.TabIndex = 19;
            btnOption3.UseVisualStyleBackColor = true;
            btnOption3.Click += btnQuickAmount_Click;
            // 
            // btnOption4
            // 
            btnOption4.Font = new Font("Segoe UI", 12F);
            btnOption4.Location = new Point(306, 284);
            btnOption4.Name = "btnOption4";
            btnOption4.Size = new Size(287, 49);
            btnOption4.TabIndex = 20;
            btnOption4.UseVisualStyleBackColor = true;
            btnOption4.Click += btnQuickAmount_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(13, 351);
            label3.Name = "label3";
            label3.Size = new Size(247, 48);
            label3.TabIndex = 21;
            label3.Text = "預計扣款 NT$";
            label3.Click += label3_Click;
            // 
            // label_deduct
            // 
            label_deduct.BorderStyle = BorderStyle.FixedSingle;
            label_deduct.Font = new Font("Segoe UI", 18F);
            label_deduct.Location = new Point(309, 355);
            label_deduct.Name = "label_deduct";
            label_deduct.Size = new Size(418, 44);
            label_deduct.TabIndex = 22;
            label_deduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_withdraw
            // 
            button_withdraw.Font = new Font("Segoe UI", 20F);
            button_withdraw.Location = new Point(13, 418);
            button_withdraw.Name = "button_withdraw";
            button_withdraw.Size = new Size(714, 74);
            button_withdraw.TabIndex = 24;
            button_withdraw.Text = "提款";
            button_withdraw.UseVisualStyleBackColor = true;
            button_withdraw.Click += button_withdraw_Click;
            // 
            // button_clear
            // 
            button_clear.Font = new Font("Segoe UI", 18F);
            button_clear.Location = new Point(600, 229);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(128, 104);
            button_clear.TabIndex = 25;
            button_clear.Text = "清除";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_withdraw);
            groupBox2.Controls.Add(button_clear);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label_deduct);
            groupBox2.Controls.Add(label_exchange_rate);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label_reverse_rate);
            groupBox2.Controls.Add(btnOption4);
            groupBox2.Controls.Add(textBox_target);
            groupBox2.Controls.Add(btnOption3);
            groupBox2.Controls.Add(btnOption1);
            groupBox2.Controls.Add(btnOption2);
            groupBox2.Location = new Point(515, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(769, 501);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // ForeignExchangeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 592);
            Controls.Add(label_current_rate);
            Controls.Add(label_currency_name);
            Controls.Add(button_back);
            Controls.Add(pictureBox_cn);
            Controls.Add(button_cn);
            Controls.Add(pictureBox_eu);
            Controls.Add(button_eu);
            Controls.Add(pictureBox_us);
            Controls.Add(button_us);
            Controls.Add(pictureBox_jp);
            Controls.Add(button_jp);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "ForeignExchangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "外幣提款";
            ((System.ComponentModel.ISupportInitialize)pictureBox_jp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_us).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cn).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_jp;
        private PictureBox pictureBox_jp;
        private PictureBox pictureBox_us;
        private Button button_us;
        private PictureBox pictureBox_eu;
        private Button button_eu;
        private PictureBox pictureBox_cn;
        private Button button_cn;
        private Label label_current_rate;
        private Button button_back;
        private Label label_currency_name;
        private Label label1;
        private Label label2;
        private Label label_exchange_rate;
        private Label label_reverse_rate;
        private GroupBox groupBox1;
        private TextBox textBox_target;
        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private Button btnOption4;
        private Label label3;
        private Label label_deduct;
        private Button button_withdraw;
        private Button button_clear;
        private GroupBox groupBox2;
    }
}