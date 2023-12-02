using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace KioskCafe
{
    public partial class Form5 : Form
    {
        private Form2 mainForm;
        private ListViewGroup group;
        private string DangDo;
        private string DangDoPrice;

        public Form5(Form2 mainForm, ListViewGroup group, string ButtonText)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.group = group; // ListViewGroup을 저장합니다.
            this.Text = ButtonText;
        }
        public void Form5_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        //totalPrice에 토핑 가격 추가
        private void upTotalPrice(string priceText)
        {
            int price = int.Parse(priceText);
            mainForm.addTotalPrice(price);
        }
        public void minusTotalPrice(string priceText)
        {
            int price = int.Parse(priceText);
            mainForm.minusTotalPrice(price);
        }

        //토핑 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice1.Text);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ㄴ" + button1.Text;
            lvi.SubItems.Add(tPrice1.Text);
            lvi.Group = group;
            mainForm.AddTopping(lvi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice2.Text);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ㄴ" + button2.Text;
            lvi.SubItems.Add(tPrice2.Text);
            lvi.Group = group;
            mainForm.AddTopping(lvi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice3.Text);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ㄴ" + button3.Text;
            lvi.SubItems.Add(tPrice3.Text);
            lvi.Group = group;
            mainForm.AddTopping(lvi);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        //종료 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DangDo = radioButton1.Text;
                DangDoPrice = tPrice5.Text;
                string textchange = tPrice5.Text.Replace("-", "").Trim();
                minusTotalPrice(textchange);
            }
            else if (radioButton2.Checked)
            {
                DangDo = radioButton2.Text;
                DangDoPrice = tPrice6.Text;
                upTotalPrice(tPrice6.Text);
            }
            else if (radioButton3.Checked)
            {
                DangDo = radioButton3.Text;
                DangDoPrice = tPrice7.Text;
                upTotalPrice(tPrice7.Text);
            }
            else
            {
                textBox2.Visible = true;
                return;
            }

            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ㄴ" + DangDo;
            lvi.SubItems.Add(DangDoPrice);
            lvi.Group = group;

            mainForm.AddTopping(lvi);
            this.Close();
        }
    }
}
