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
    public partial class Form3 : Form
    {
        private Form2 mainForm;
        private ListViewGroup group;
        //종료 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form3(Form2 mainForm, ListViewGroup group, string buttonText)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.group = group;                         // ListViewGroup을 저장
            this.Text = buttonText;
        }


        //totalPrice에 토핑 가격 추가
        private void upTotalPrice(string priceText)
        {
            int price = int.Parse(priceText);
            mainForm.addTotalPrice(price);
        }

        //토핑 버튼                                             // 6개 모두 동일 함으로 첫번째만 설명
        private void button1_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice1.Text);                         // 토핑 가격 총 가격에 더하기
            ListViewItem lvi = new ListViewItem();              // ListView 사용
            lvi.Text = "ㄴ" + button1.Text;                     // ListView에 첫번째 열에 토핑 문구 추가
            lvi.SubItems.Add(tPrice1.Text);                     // ListView에 두번째 열에 가격 문구 추가
            lvi.Group = group;                                  // 그룹화
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
        private void button5_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice5.Text);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ㄴ" + button5.Text;
            lvi.SubItems.Add(tPrice5.Text);
            lvi.Group = group;
            mainForm.AddTopping(lvi);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice6.Text);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ㄴ" + button6.Text;
            lvi.SubItems.Add(tPrice6.Text);
            lvi.Group = group;
            mainForm.AddTopping(lvi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice7.Text);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ㄴ" + button7.Text;
            lvi.SubItems.Add(tPrice7.Text);
            lvi.Group = group;
            mainForm.AddTopping(lvi);
        }
    }   
}
