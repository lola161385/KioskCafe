namespace KioskCafe
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            coffeeButton = new Button();
            smoothieButton = new Button();
            backButton = new Button();
            dessertButton = new Button();
            totalPrice = new TextBox();
            menuButton_1 = new Button();
            menuButton_2 = new Button();
            menuButton_3 = new Button();
            menuButton_4 = new Button();
            menuButton_5 = new Button();
            menuButton_6 = new Button();
            menuPrice_1 = new TextBox();
            menuPrice_2 = new TextBox();
            menuPrice_3 = new TextBox();
            menuPrice_4 = new TextBox();
            menuPrice_5 = new TextBox();
            menuPrice_6 = new TextBox();
            purchase_Button = new Button();
            cancel_Button = new Button();
            menuPrice_11 = new TextBox();
            menuPrice_12 = new TextBox();
            menuPrice_7 = new TextBox();
            menuPrice_8 = new TextBox();
            menuPrice_9 = new TextBox();
            menuPrice_10 = new TextBox();
            menuButton_11 = new Button();
            menuButton_12 = new Button();
            menuButton_7 = new Button();
            menuButton_8 = new Button();
            menuButton_9 = new Button();
            menuButton_10 = new Button();
            orderType1 = new TextBox();
            listView1 = new ListView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            SuspendLayout();
            // 
            // coffeeButton
            // 
            coffeeButton.BackColor = Color.MediumPurple;
            coffeeButton.FlatAppearance.BorderSize = 0;
            coffeeButton.FlatStyle = FlatStyle.Flat;
            coffeeButton.Location = new Point(2, 2);
            coffeeButton.Name = "coffeeButton";
            coffeeButton.Size = new Size(140, 75);
            coffeeButton.TabIndex = 0;
            coffeeButton.Text = "커피";
            coffeeButton.UseVisualStyleBackColor = false;
            coffeeButton.Click += button_selectCoffee;
            // 
            // smoothieButton
            // 
            smoothieButton.BackColor = Color.MediumOrchid;
            smoothieButton.FlatAppearance.BorderSize = 0;
            smoothieButton.FlatStyle = FlatStyle.Flat;
            smoothieButton.Location = new Point(147, 2);
            smoothieButton.Name = "smoothieButton";
            smoothieButton.Size = new Size(140, 75);
            smoothieButton.TabIndex = 1;
            smoothieButton.Text = "스무디";
            smoothieButton.UseVisualStyleBackColor = false;
            smoothieButton.Click += button_selectSmoothie;
            // 
            // backButton
            // 
            backButton.Location = new Point(273, 688);
            backButton.Name = "backButton";
            backButton.Size = new Size(47, 61);
            backButton.TabIndex = 18;
            backButton.Text = "초기화면";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += Form1_Load;
            // 
            // dessertButton
            // 
            dessertButton.BackColor = Color.MediumOrchid;
            dessertButton.FlatAppearance.BorderSize = 0;
            dessertButton.FlatStyle = FlatStyle.Flat;
            dessertButton.Location = new Point(292, 2);
            dessertButton.Name = "dessertButton";
            dessertButton.Size = new Size(140, 75);
            dessertButton.TabIndex = 23;
            dessertButton.Text = "디저트";
            dessertButton.UseVisualStyleBackColor = false;
            dessertButton.Click += button_selectDessert;
            // 
            // totalPrice
            // 
            totalPrice.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            totalPrice.Location = new Point(14, 592);
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Size = new Size(250, 23);
            totalPrice.TabIndex = 9;
            totalPrice.Text = "20000원";
            totalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // menuButton_1
            // 
            menuButton_1.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_1.Location = new Point(12, 83);
            menuButton_1.Name = "menuButton_1";
            menuButton_1.Size = new Size(96, 132);
            menuButton_1.TabIndex = 10;
            menuButton_1.Text = "칸1";
            menuButton_1.UseVisualStyleBackColor = true;
            menuButton_1.Click += button_selectMenu_1;
            // 
            // menuButton_2
            // 
            menuButton_2.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_2.Location = new Point(114, 83);
            menuButton_2.Name = "menuButton_2";
            menuButton_2.Size = new Size(96, 132);
            menuButton_2.TabIndex = 11;
            menuButton_2.Text = "칸2";
            menuButton_2.UseVisualStyleBackColor = true;
            menuButton_2.Click += button_selectMenu_2;
            // 
            // menuButton_3
            // 
            menuButton_3.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_3.Location = new Point(224, 82);
            menuButton_3.Name = "menuButton_3";
            menuButton_3.Size = new Size(96, 132);
            menuButton_3.TabIndex = 6;
            menuButton_3.Text = "칸3";
            menuButton_3.UseVisualStyleBackColor = true;
            menuButton_3.Click += button_selectMenu_3;
            // 
            // menuButton_4
            // 
            menuButton_4.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_4.Location = new Point(325, 82);
            menuButton_4.Name = "menuButton_4";
            menuButton_4.Size = new Size(96, 132);
            menuButton_4.TabIndex = 13;
            menuButton_4.Text = "칸4";
            menuButton_4.UseVisualStyleBackColor = true;
            menuButton_4.Click += button_selectMenu_4;
            // 
            // menuButton_5
            // 
            menuButton_5.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_5.Location = new Point(12, 252);
            menuButton_5.Name = "menuButton_5";
            menuButton_5.Size = new Size(96, 132);
            menuButton_5.TabIndex = 14;
            menuButton_5.Text = "칸5";
            menuButton_5.UseVisualStyleBackColor = true;
            menuButton_5.Click += button_selectMenu_5;
            // 
            // menuButton_6
            // 
            menuButton_6.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_6.Location = new Point(114, 252);
            menuButton_6.Name = "menuButton_6";
            menuButton_6.Size = new Size(96, 132);
            menuButton_6.TabIndex = 12;
            menuButton_6.Text = "칸6";
            menuButton_6.UseVisualStyleBackColor = true;
            menuButton_6.Click += button_selectMenu_6;
            // 
            // menuPrice_1
            // 
            menuPrice_1.BorderStyle = BorderStyle.None;
            menuPrice_1.Location = new Point(12, 235);
            menuPrice_1.Name = "menuPrice_1";
            menuPrice_1.ReadOnly = true;
            menuPrice_1.Size = new Size(96, 16);
            menuPrice_1.TabIndex = 15;
            menuPrice_1.Text = "10000원";
            menuPrice_1.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_2
            // 
            menuPrice_2.BorderStyle = BorderStyle.None;
            menuPrice_2.Location = new Point(114, 235);
            menuPrice_2.Name = "menuPrice_2";
            menuPrice_2.ReadOnly = true;
            menuPrice_2.Size = new Size(96, 16);
            menuPrice_2.TabIndex = 16;
            menuPrice_2.Text = "10000원";
            menuPrice_2.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_3
            // 
            menuPrice_3.BorderStyle = BorderStyle.None;
            menuPrice_3.Location = new Point(224, 235);
            menuPrice_3.Name = "menuPrice_3";
            menuPrice_3.ReadOnly = true;
            menuPrice_3.Size = new Size(96, 16);
            menuPrice_3.TabIndex = 17;
            menuPrice_3.Text = "10000원";
            menuPrice_3.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_4
            // 
            menuPrice_4.BorderStyle = BorderStyle.None;
            menuPrice_4.Location = new Point(325, 235);
            menuPrice_4.Name = "menuPrice_4";
            menuPrice_4.ReadOnly = true;
            menuPrice_4.Size = new Size(96, 16);
            menuPrice_4.TabIndex = 19;
            menuPrice_4.Text = "10000원";
            menuPrice_4.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_5
            // 
            menuPrice_5.BorderStyle = BorderStyle.None;
            menuPrice_5.Location = new Point(12, 403);
            menuPrice_5.Name = "menuPrice_5";
            menuPrice_5.ReadOnly = true;
            menuPrice_5.Size = new Size(96, 16);
            menuPrice_5.TabIndex = 20;
            menuPrice_5.Text = "10000원";
            menuPrice_5.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_6
            // 
            menuPrice_6.BorderStyle = BorderStyle.None;
            menuPrice_6.Location = new Point(114, 403);
            menuPrice_6.Name = "menuPrice_6";
            menuPrice_6.ReadOnly = true;
            menuPrice_6.Size = new Size(96, 16);
            menuPrice_6.TabIndex = 21;
            menuPrice_6.Text = "10000원";
            menuPrice_6.TextAlign = HorizontalAlignment.Center;
            // 
            // purchase_Button
            // 
            purchase_Button.Location = new Point(326, 621);
            purchase_Button.Name = "purchase_Button";
            purchase_Button.Size = new Size(96, 128);
            purchase_Button.TabIndex = 8;
            purchase_Button.Text = "결제";
            purchase_Button.UseVisualStyleBackColor = true;
            purchase_Button.Click += purchase_Button_Click;
            // 
            // cancel_Button
            // 
            cancel_Button.Location = new Point(273, 621);
            cancel_Button.Name = "cancel_Button";
            cancel_Button.Size = new Size(47, 61);
            cancel_Button.TabIndex = 22;
            cancel_Button.Text = "메뉴 빼기";
            cancel_Button.UseVisualStyleBackColor = true;
            cancel_Button.Click += cancel_Button_Click;
            // 
            // menuPrice_11
            // 
            menuPrice_11.BorderStyle = BorderStyle.None;
            menuPrice_11.Location = new Point(224, 573);
            menuPrice_11.Name = "menuPrice_11";
            menuPrice_11.ReadOnly = true;
            menuPrice_11.Size = new Size(96, 16);
            menuPrice_11.TabIndex = 30;
            menuPrice_11.Text = "10000원";
            menuPrice_11.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_12
            // 
            menuPrice_12.BorderStyle = BorderStyle.None;
            menuPrice_12.Location = new Point(325, 573);
            menuPrice_12.Name = "menuPrice_12";
            menuPrice_12.ReadOnly = true;
            menuPrice_12.Size = new Size(96, 16);
            menuPrice_12.TabIndex = 31;
            menuPrice_12.Text = "10000원";
            menuPrice_12.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_7
            // 
            menuPrice_7.BorderStyle = BorderStyle.None;
            menuPrice_7.Location = new Point(223, 403);
            menuPrice_7.Name = "menuPrice_7";
            menuPrice_7.ReadOnly = true;
            menuPrice_7.Size = new Size(96, 16);
            menuPrice_7.TabIndex = 32;
            menuPrice_7.Text = "10000원";
            menuPrice_7.TextAlign = HorizontalAlignment.Center;
            menuPrice_7.TextChanged += menuPrice_7_TextChanged;
            // 
            // menuPrice_8
            // 
            menuPrice_8.BorderStyle = BorderStyle.None;
            menuPrice_8.Location = new Point(325, 403);
            menuPrice_8.Name = "menuPrice_8";
            menuPrice_8.ReadOnly = true;
            menuPrice_8.Size = new Size(96, 16);
            menuPrice_8.TabIndex = 33;
            menuPrice_8.Text = "10000원";
            menuPrice_8.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_9
            // 
            menuPrice_9.BorderStyle = BorderStyle.None;
            menuPrice_9.Location = new Point(12, 573);
            menuPrice_9.Name = "menuPrice_9";
            menuPrice_9.ReadOnly = true;
            menuPrice_9.Size = new Size(96, 16);
            menuPrice_9.TabIndex = 34;
            menuPrice_9.Text = "10000원";
            menuPrice_9.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_10
            // 
            menuPrice_10.BorderStyle = BorderStyle.None;
            menuPrice_10.Location = new Point(118, 573);
            menuPrice_10.Name = "menuPrice_10";
            menuPrice_10.ReadOnly = true;
            menuPrice_10.Size = new Size(96, 16);
            menuPrice_10.TabIndex = 35;
            menuPrice_10.Text = "10000원";
            menuPrice_10.TextAlign = HorizontalAlignment.Center;
            // 
            // menuButton_11
            // 
            menuButton_11.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_11.Location = new Point(224, 423);
            menuButton_11.Name = "menuButton_11";
            menuButton_11.Size = new Size(96, 132);
            menuButton_11.TabIndex = 25;
            menuButton_11.Text = "칸11";
            menuButton_11.UseVisualStyleBackColor = true;
            menuButton_11.Click += button_selectMenu_11;
            // 
            // menuButton_12
            // 
            menuButton_12.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_12.Location = new Point(325, 423);
            menuButton_12.Name = "menuButton_12";
            menuButton_12.Size = new Size(96, 132);
            menuButton_12.TabIndex = 26;
            menuButton_12.Text = "칸12";
            menuButton_12.UseVisualStyleBackColor = true;
            menuButton_12.Click += button_selectMenu_12;
            // 
            // menuButton_7
            // 
            menuButton_7.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_7.Location = new Point(223, 252);
            menuButton_7.Name = "menuButton_7";
            menuButton_7.Size = new Size(96, 132);
            menuButton_7.TabIndex = 24;
            menuButton_7.Text = "칸7";
            menuButton_7.UseVisualStyleBackColor = true;
            menuButton_7.Click += button_selectMenu_7;
            // 
            // menuButton_8
            // 
            menuButton_8.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_8.Location = new Point(325, 252);
            menuButton_8.Name = "menuButton_8";
            menuButton_8.Size = new Size(96, 132);
            menuButton_8.TabIndex = 28;
            menuButton_8.Text = "칸8";
            menuButton_8.UseVisualStyleBackColor = true;
            menuButton_8.Click += button_selectMenu_8;
            // 
            // menuButton_9
            // 
            menuButton_9.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_9.Location = new Point(12, 423);
            menuButton_9.Name = "menuButton_9";
            menuButton_9.Size = new Size(96, 132);
            menuButton_9.TabIndex = 29;
            menuButton_9.Text = "칸9";
            menuButton_9.UseVisualStyleBackColor = true;
            menuButton_9.Click += button_selectMenu_9;
            // 
            // menuButton_10
            // 
            menuButton_10.Font = new Font("맑은 고딕 Semilight", 1.5F);
            menuButton_10.Location = new Point(118, 423);
            menuButton_10.Name = "menuButton_10";
            menuButton_10.Size = new Size(96, 132);
            menuButton_10.TabIndex = 27;
            menuButton_10.Text = "칸10";
            menuButton_10.UseVisualStyleBackColor = true;
            menuButton_10.Click += button_selectMenu_10;
            // 
            // orderType1
            // 
            orderType1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            orderType1.Location = new Point(273, 592);
            orderType1.Name = "orderType1";
            orderType1.ReadOnly = true;
            orderType1.Size = new Size(149, 23);
            orderType1.TabIndex = 36;
            orderType1.Text = "매장";
            orderType1.TextAlign = HorizontalAlignment.Center;
            orderType1.TextChanged += orderType1_TextChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(14, 621);
            listView1.Name = "listView1";
            listView1.Size = new Size(250, 128);
            listView1.TabIndex = 37;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 215);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(96, 16);
            textBox1.TabIndex = 38;
            textBox1.Text = "칸1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(114, 215);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(96, 16);
            textBox2.TabIndex = 39;
            textBox2.Text = "칸2";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(224, 215);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(96, 16);
            textBox3.TabIndex = 40;
            textBox3.Text = "칸3";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(325, 215);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(96, 16);
            textBox4.TabIndex = 41;
            textBox4.Text = "칸4";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(12, 384);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(96, 16);
            textBox5.TabIndex = 42;
            textBox5.Text = "칸5";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(114, 384);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(96, 16);
            textBox6.TabIndex = 43;
            textBox6.Text = "칸6";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(224, 383);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(96, 16);
            textBox7.TabIndex = 44;
            textBox7.Text = "칸7";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(325, 383);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(96, 16);
            textBox8.TabIndex = 45;
            textBox8.Text = "칸8";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(12, 556);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(96, 16);
            textBox9.TabIndex = 46;
            textBox9.Text = "칸9";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(118, 556);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(96, 16);
            textBox10.TabIndex = 47;
            textBox10.Text = "칸10";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Location = new Point(224, 556);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(96, 16);
            textBox11.TabIndex = 48;
            textBox11.Text = "칸11";
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Location = new Point(325, 556);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(96, 16);
            textBox12.TabIndex = 49;
            textBox12.Text = "칸12";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 761);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(orderType1);
            Controls.Add(menuPrice_11);
            Controls.Add(menuPrice_12);
            Controls.Add(menuPrice_7);
            Controls.Add(menuPrice_8);
            Controls.Add(menuPrice_9);
            Controls.Add(menuPrice_10);
            Controls.Add(menuButton_11);
            Controls.Add(menuButton_12);
            Controls.Add(menuButton_7);
            Controls.Add(menuButton_8);
            Controls.Add(menuButton_9);
            Controls.Add(menuButton_10);
            Controls.Add(menuPrice_1);
            Controls.Add(menuPrice_2);
            Controls.Add(menuPrice_3);
            Controls.Add(menuPrice_4);
            Controls.Add(menuPrice_5);
            Controls.Add(menuPrice_6);
            Controls.Add(menuButton_1);
            Controls.Add(menuButton_2);
            Controls.Add(menuButton_3);
            Controls.Add(menuButton_4);
            Controls.Add(menuButton_5);
            Controls.Add(menuButton_6);
            Controls.Add(totalPrice);
            Controls.Add(purchase_Button);
            Controls.Add(cancel_Button);
            Controls.Add(coffeeButton);
            Controls.Add(smoothieButton);
            Controls.Add(backButton);
            Controls.Add(dessertButton);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Button coffeeButton;
        private Button smoothieButton;
        private Button backButton;
        private Button dessertButton;

        private Button menuButton_1;
        private Button menuButton_2;
        private Button menuButton_3;
        private Button menuButton_4;
        private Button menuButton_5;
        private Button menuButton_6;
        private Button purchase_Button;
        private TextBox totalPrice;

        private TextBox menuPrice_1;
        private TextBox menuPrice_2;
        private TextBox menuPrice_3;
        private TextBox menuPrice_4;
        private TextBox menuPrice_5;
        private TextBox menuPrice_6;

        private Button cancel_Button;
        private TextBox menuPrice_11;
        private TextBox menuPrice_12;
        private TextBox menuPrice_7;
        private TextBox menuPrice_8;
        private TextBox menuPrice_9;
        private TextBox menuPrice_10;
        private Button menuButton_11;
        private Button menuButton_12;
        private Button menuButton_7;
        private Button menuButton_8;
        private Button menuButton_9;
        private Button menuButton_10;
        private TextBox orderType1;
        public ListView listView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
    }
}