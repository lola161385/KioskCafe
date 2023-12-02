namespace KioskCafe
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnDineln = new Button();
            btnTakeOut = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // btnDineln 매장 버튼
            // 
            btnDineln.BackgroundImage = Properties.Resources.online_store_1674907_640;
            btnDineln.BackgroundImageLayout = ImageLayout.Stretch;
            btnDineln.FlatStyle = FlatStyle.Popup;
            btnDineln.Font = new Font("휴먼편지체", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDineln.Location = new Point(12, 291);
            btnDineln.Name = "btnDineln";
            btnDineln.Size = new Size(183, 197);
            btnDineln.TabIndex = 0;
            btnDineln.Text = "매장";
            btnDineln.TextAlign = ContentAlignment.BottomCenter;
            btnDineln.UseVisualStyleBackColor = true;
            btnDineln.Click += btnDineln_Click;
            // 
            // btnTakeOut 포장 버튼
            // 
            btnTakeOut.BackgroundImage = Properties.Resources.coffee_drink_2433133_640;
            btnTakeOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnTakeOut.FlatStyle = FlatStyle.Popup;
            btnTakeOut.Font = new Font("휴먼편지체", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnTakeOut.Location = new Point(239, 291);
            btnTakeOut.Name = "btnTakeOut";
            btnTakeOut.Size = new Size(183, 197);
            btnTakeOut.TabIndex = 1;
            btnTakeOut.Text = "포장";
            btnTakeOut.TextAlign = ContentAlignment.BottomCenter;
            btnTakeOut.UseVisualStyleBackColor = true;
            btnTakeOut.Click += btnTakeOut_Click;
            // 
            // label1 카페 명
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("한컴산뜻돋움", 21.7499962F, FontStyle.Bold);
            label1.ForeColor = Color.Violet;
            label1.Location = new Point(351, 714);
            label1.Name = "label1";
            label1.Size = new Size(71, 38);
            label1.TabIndex = 3;
            label1.Text = "카페";
            // 
            // Form1 폼에대한 정보
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 761);
            Controls.Add(label1);
            Controls.Add(btnTakeOut);
            Controls.Add(btnDineln);
            Name = "Form1";
            Text = "매장/포장";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDineln;
        private Button btnTakeOut;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
    }
}