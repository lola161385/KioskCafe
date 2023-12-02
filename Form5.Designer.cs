namespace KioskCafe
{
    partial class Form5
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
            button2 = new Button();
            button3 = new Button();
            tPrice1 = new TextBox();
            tPrice2 = new TextBox();
            tPrice3 = new TextBox();
            tPrice5 = new TextBox();
            tPrice6 = new TextBox();
            tPrice7 = new TextBox();
            button4 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.BackgroundImage = Properties.Resources.milkfoam;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(125, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(118, 159);
            button1.TabIndex = 0;
            button1.Text = "밀크폼";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.BackgroundImage = Properties.Resources.fall;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(3, 11);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(120, 159);
            button2.TabIndex = 1;
            button2.Text = "펄(타피오카)";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.BackgroundImage = Properties.Resources.cheesefoam;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.Location = new Point(245, 11);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(116, 159);
            button3.TabIndex = 2;
            button3.Text = "치즈폼";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tPrice1
            // 
            tPrice1.BorderStyle = BorderStyle.None;
            tPrice1.Location = new Point(27, 171);
            tPrice1.Name = "tPrice1";
            tPrice1.ReadOnly = true;
            tPrice1.Size = new Size(72, 16);
            tPrice1.TabIndex = 16;
            tPrice1.Text = "800";
            tPrice1.TextAlign = HorizontalAlignment.Center;
            // 
            // tPrice2
            // 
            tPrice2.BorderStyle = BorderStyle.None;
            tPrice2.Location = new Point(148, 171);
            tPrice2.Name = "tPrice2";
            tPrice2.ReadOnly = true;
            tPrice2.Size = new Size(72, 16);
            tPrice2.TabIndex = 17;
            tPrice2.Text = "1000";
            tPrice2.TextAlign = HorizontalAlignment.Center;
            // 
            // tPrice3
            // 
            tPrice3.BorderStyle = BorderStyle.None;
            tPrice3.Location = new Point(269, 171);
            tPrice3.Name = "tPrice3";
            tPrice3.ReadOnly = true;
            tPrice3.Size = new Size(72, 16);
            tPrice3.TabIndex = 18;
            tPrice3.Text = "800";
            tPrice3.TextAlign = HorizontalAlignment.Center;
            // 
            // tPrice5
            // 
            tPrice5.BorderStyle = BorderStyle.None;
            tPrice5.Location = new Point(9, 247);
            tPrice5.Name = "tPrice5";
            tPrice5.ReadOnly = true;
            tPrice5.Size = new Size(72, 16);
            tPrice5.TabIndex = 25;
            tPrice5.Text = "-300";
            tPrice5.TextAlign = HorizontalAlignment.Center;
            // 
            // tPrice6
            // 
            tPrice6.BorderStyle = BorderStyle.None;
            tPrice6.Location = new Point(148, 247);
            tPrice6.Name = "tPrice6";
            tPrice6.ReadOnly = true;
            tPrice6.Size = new Size(72, 16);
            tPrice6.TabIndex = 24;
            tPrice6.Text = "0";
            tPrice6.TextAlign = HorizontalAlignment.Center;
            // 
            // tPrice7
            // 
            tPrice7.BorderStyle = BorderStyle.None;
            tPrice7.Location = new Point(278, 247);
            tPrice7.Name = "tPrice7";
            tPrice7.ReadOnly = true;
            tPrice7.Size = new Size(72, 16);
            tPrice7.TabIndex = 23;
            tPrice7.Text = "300";
            tPrice7.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.finish;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(300, 277);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 19;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(255, 192, 192);
            radioButton1.Location = new Point(17, 222);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "덜 달게";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(255, 128, 128);
            radioButton2.Location = new Point(143, 222);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "보통 달게";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Red;
            radioButton3.Location = new Point(288, 222);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 28;
            radioButton3.TabStop = true;
            radioButton3.Text = "달게";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 193);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(351, 16);
            textBox1.TabIndex = 29;
            textBox1.Text = "당도 선택 ──────────────────────────";
            // 
            // textBox2
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(12, 292);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 30;
            textBox1.ReadOnly = true;
            textBox2.Text = "※ 당도를 선택하셔야합니다!";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 338);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button4);
            Controls.Add(tPrice7);
            Controls.Add(tPrice6);
            Controls.Add(tPrice5);
            Controls.Add(tPrice3);
            Controls.Add(tPrice2);
            Controls.Add(tPrice1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form5";
            Text = "스무디 토핑 추가";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox tPrice1;
        private TextBox tPrice2;
        private TextBox tPrice3;
        private TextBox tPrice5;
        private TextBox tPrice6;
        private TextBox tPrice7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}