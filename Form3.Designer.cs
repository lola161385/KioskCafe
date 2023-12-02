namespace KioskCafe
{
 partial class Form3
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
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            tPrice1 = new TextBox();
            tPrice2 = new TextBox();
            tPrice3 = new TextBox();
            tPrice5 = new TextBox();
            tPrice6 = new TextBox();
            tPrice7 = new TextBox();
            button4 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.ice;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("휴먼둥근헤드라인", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(9, 23);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(91, 87);
            button1.TabIndex = 0;
            button1.Text = "아이스";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.wippedcream;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("휴먼둥근헤드라인", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(139, 23);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(91, 87);
            button2.TabIndex = 1;
            button2.Text = "휘핑크림 추가";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.javachip;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("휴먼둥근헤드라인", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.White;
            button3.Location = new Point(269, 23);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(91, 87);
            button3.TabIndex = 2;
            button3.Text = "자바칩추가";
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.sirup;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("휴먼둥근헤드라인", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button5.ForeColor = Color.Black;
            button5.ImageAlign = ContentAlignment.BottomCenter;
            button5.Location = new Point(269, 154);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(91, 87);
            button5.TabIndex = 22;
            button5.Text = "시럽 추가";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = Properties.Resources.dalgona;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("휴먼둥근헤드라인", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button6.Location = new Point(139, 154);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(91, 87);
            button6.TabIndex = 21;
            button6.Text = "달고나 추가";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.coffee;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("휴먼둥근헤드라인", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button7.Location = new Point(9, 154);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(91, 87);
            button7.TabIndex = 20;
            button7.Text = "샷추가";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // tPrice1
            // 
            tPrice1.BorderStyle = BorderStyle.None;
            tPrice1.Location = new Point(17, 116);
            tPrice1.Name = "tPrice1";
            tPrice1.Size = new Size(72, 16);
            tPrice1.TabIndex = 16;
            tPrice1.Text = "500";
            tPrice1.TextAlign = HorizontalAlignment.Center;
            tPrice1.ReadOnly = true;
            // 
            // tPrice2
            // 
            tPrice2.BorderStyle = BorderStyle.None;
            tPrice2.Location = new Point(148, 116);
            tPrice2.Name = "tPrice2";
            tPrice2.Size = new Size(72, 16);
            tPrice2.TabIndex = 17;
            tPrice2.Text = "300";
            tPrice2.TextAlign = HorizontalAlignment.Center;
            tPrice2.ReadOnly = true;
            // 
            // tPrice3
            // 
            tPrice3.BorderStyle = BorderStyle.None;
            tPrice3.Location = new Point(278, 116);
            tPrice3.Name = "tPrice3";
            tPrice3.Size = new Size(72, 16);
            tPrice3.TabIndex = 18;
            tPrice3.Text = "600";
            tPrice3.TextAlign = HorizontalAlignment.Center;
            tPrice3.ReadOnly = true;
            // 
            // tPrice5
            // 
            tPrice5.BorderStyle = BorderStyle.None;
            tPrice5.Location = new Point(278, 247);
            tPrice5.Name = "tPrice5";
            tPrice5.Size = new Size(72, 16);
            tPrice5.TabIndex = 25;
            tPrice5.Text = "200";
            tPrice5.TextAlign = HorizontalAlignment.Center;
            tPrice5.ReadOnly = true;
            // 
            // tPrice6
            // 
            tPrice6.BorderStyle = BorderStyle.None;
            tPrice6.Location = new Point(148, 247);
            tPrice6.Name = "tPrice6";
            tPrice6.Size = new Size(72, 16);
            tPrice6.TabIndex = 24;
            tPrice6.Text = "300";
            tPrice6.TextAlign = HorizontalAlignment.Center;
            tPrice6.ReadOnly = true;
            // 
            // tPrice7
            // 
            tPrice7.BorderStyle = BorderStyle.None;
            tPrice7.Location = new Point(17, 247);
            tPrice7.Name = "tPrice7";
            tPrice7.Size = new Size(72, 16);
            tPrice7.TabIndex = 23;
            tPrice7.Text = "1000";
            tPrice7.TextAlign = HorizontalAlignment.Center;
            tPrice7.ReadOnly = true;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.finish;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(291, 277);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 19;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("휴먼모음T", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox4.Location = new Point(9, 295);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 14);
            textBox4.TabIndex = 26;
            textBox4.Text = "※ 아이스 미 선택시 따뜻한 음료로 주문됩니다.";
            textBox4.ReadOnly= true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 338);
            Controls.Add(textBox4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
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
            Name = "Form3";
            Text = "Form2";
            //Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox tPrice1;
        private TextBox tPrice2;
        private TextBox tPrice3;
        private TextBox tPrice5;
        private TextBox tPrice6;
        private TextBox tPrice7;
        private TextBox textBox4;
    }
}