using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KioskCafe
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            textBoxTotalPriceForm4 = new TextBox();
            cashbutton = new Button();
            cardbutton = new Button();
            couponbutton = new Button();
            Message = new Label();
            cancelButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            orderNumberButton = new Button();
            receiptButton = new Button();
            cash_input = new TextBox();
            cash_button = new Button();
            SuspendLayout();
            // 
            // textBoxTotalPriceForm4
            // 
            textBoxTotalPriceForm4.Location = new Point(9, 278);
            textBoxTotalPriceForm4.Margin = new Padding(2);
            textBoxTotalPriceForm4.Name = "textBoxTotalPriceForm4";
            textBoxTotalPriceForm4.ReadOnly = true;
            textBoxTotalPriceForm4.Size = new Size(413, 23);
            textBoxTotalPriceForm4.TabIndex = 0;
            textBoxTotalPriceForm4.TextAlign = HorizontalAlignment.Right;
            // 
            // cashbutton
            // 
            cashbutton.BackgroundImage = Properties.Resources.cash;
            cashbutton.BackgroundImageLayout = ImageLayout.Stretch;
            cashbutton.FlatAppearance.BorderSize = 0;
            cashbutton.FlatStyle = FlatStyle.Flat;
            cashbutton.Font = new System.Drawing.Font("맑은 고딕 Semilight", 2.25F);
            cashbutton.Location = new Point(9, 75);
            cashbutton.Margin = new Padding(2);
            cashbutton.Name = "cashbutton";
            cashbutton.Size = new Size(132, 128);
            cashbutton.TabIndex = 1;
            cashbutton.Text = "현금";
            cashbutton.UseVisualStyleBackColor = true;
            cashbutton.Click += cashbutton_Click;
            // 
            // cardbutton
            // 
            cardbutton.BackgroundImage = Properties.Resources.credit_card;
            cardbutton.BackgroundImageLayout = ImageLayout.Stretch;
            cardbutton.FlatAppearance.BorderSize = 0;
            cardbutton.FlatStyle = FlatStyle.Flat;
            cardbutton.Font = new System.Drawing.Font("맑은 고딕 Semilight", 2.25F);
            cardbutton.Location = new Point(155, 75);
            cardbutton.Margin = new Padding(2);
            cardbutton.Name = "cardbutton";
            cardbutton.Size = new Size(132, 128);
            cardbutton.TabIndex = 2;
            cardbutton.Text = "카드";
            cardbutton.UseVisualStyleBackColor = true;
            cardbutton.Click += cardbutton_Click;
            // 
            // couponbutton
            // 
            couponbutton.BackgroundImage = Properties.Resources.coupon;
            couponbutton.BackgroundImageLayout = ImageLayout.Stretch;
            couponbutton.FlatAppearance.BorderSize = 0;
            couponbutton.FlatStyle = FlatStyle.Flat;
            couponbutton.Font = new System.Drawing.Font("맑은 고딕 Semilight", 2.25F);
            couponbutton.Location = new Point(289, 75);
            couponbutton.Margin = new Padding(2);
            couponbutton.Name = "couponbutton";
            couponbutton.Size = new Size(132, 128);
            couponbutton.TabIndex = 3;
            couponbutton.Text = "쿠폰";
            couponbutton.UseVisualStyleBackColor = true;
            couponbutton.Click += couponbutton_Click;
            // 
            // Message
            // 
            Message.Location = new Point(63, 16);
            Message.Margin = new Padding(2, 0, 2, 0);
            Message.Name = "Message";
            Message.Size = new Size(311, 315);
            Message.TabIndex = 4;
            Message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(179, 258);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(73, 43);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "취소";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancleButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            // 
            // timer2
            // 
            timer2.Interval = 5000;
            // 
            // timer3
            // 
            timer3.Interval = 5000;
            // 
            // timer4
            // 
            timer4.Interval = 5000;
            // 
            // orderNumberButton
            // 
            orderNumberButton.Font = new System.Drawing.Font("휴먼매직체", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            orderNumberButton.Location = new Point(108, 96);
            orderNumberButton.Name = "orderNumberButton";
            orderNumberButton.Size = new Size(89, 107);
            orderNumberButton.TabIndex = 6;
            orderNumberButton.Text = "주문번호만 출력";
            orderNumberButton.UseVisualStyleBackColor = true;
            orderNumberButton.Click += orderNumberButton_Click;
            // 
            // receiptButton
            // 
            receiptButton.Font = new System.Drawing.Font("휴먼매직체", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            receiptButton.Location = new Point(246, 96);
            receiptButton.Name = "receiptButton";
            receiptButton.Size = new Size(89, 107);
            receiptButton.TabIndex = 7;
            receiptButton.Text = "영수증   출력";
            receiptButton.UseVisualStyleBackColor = true;
            receiptButton.Click += receiptButton_Click;
            // 
            // cash_input
            // 
            cash_input.Location = new Point(99, 228);
            cash_input.Name = "cash_input";
            cash_input.Size = new Size(170, 23);
            cash_input.TabIndex = 8;
            cash_input.Text = "원";
            cash_input.TextAlign = HorizontalAlignment.Right;
            cash_input.TextChanged += textBox1_TextChanged;
            // 
            // cash_button
            // 
            cash_button.Location = new Point(275, 228);
            cash_button.Name = "cash_button";
            cash_button.Size = new Size(75, 23);
            cash_button.TabIndex = 9;
            cash_button.Text = "현금 넣기";
            cash_button.UseVisualStyleBackColor = true;
            cash_button.Click += Cash_button_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 340);
            Controls.Add(cash_button);
            Controls.Add(cash_input);
            Controls.Add(receiptButton);
            Controls.Add(orderNumberButton);
            Controls.Add(cancelButton);
            Controls.Add(Message);
            Controls.Add(couponbutton);
            Controls.Add(cardbutton);
            Controls.Add(cashbutton);
            Controls.Add(textBoxTotalPriceForm4);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "결제";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Cash_button_Click(object sender, EventArgs e)
        {
            cash_button_Click(sender, e);
        }

        #endregion

        private TextBox textBoxTotalPriceForm4;
        private Button cashbutton;
        private Button cardbutton;
        private Button couponbutton;
        private Label Message;
        private Button cancelButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Button orderNumberButton;
        private Button receiptButton;
        private TextBox cash_input;
        private Button cash_button;
    }
}