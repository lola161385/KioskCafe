using KioskCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using ListView = System.Windows.Forms.ListView;
using Timer = System.Windows.Forms.Timer;

namespace KioskCafe
{
    public partial class Form4 : Form
    {
        private int totalPriceForm2;
        private String paymentMethod;
        private ListView SelectedMenuList;
        private static int ticketNumber = 1;
        private Form2 form2;
        public int cashAmount =0;
        public int change = 0;
        public int status = 0;

        public Form4(Form2 form2)
        {
            this.form2 = form2;
            this.SelectedMenuList = form2.listView1;
            InitializeComponent();

            timer1.Tick += timer1_Tick; // 다자이너 코드에 5000 설정 5초
            timer2.Tick += timer2_Tick; // 다자이너 코드에 5000 설정 5초
            timer3.Tick += timer3_Tick; // 다자이너 코드에 5000 설정 5초
            timer4.Tick += timer4_Tick; // 다자이너 코드에 5000 설정 5초
        }

        public int TotalPriceForm4
        {
            get { return totalPriceForm2; }
            set { totalPriceForm2 = value; }
        }

        // form4 실행시 기본 설정 값
        private void Form4_Load(object sender, EventArgs e)
        {
            int totalPriceForm4Value = TotalPriceForm4;
            textBoxTotalPriceForm4.Visible = true;
            Message.Visible = false;
            cancelButton.Visible = false;
            orderNumberButton.Visible = false;
            receiptButton.Visible = false;
            cash_button.Visible = false;
            cash_input.Visible = false;
            textBoxTotalPriceForm4.Text = $"{totalPriceForm4Value} 원";
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            Console.WriteLine("timer1_Tick 메서드가 호출되었습니다.");
            timer1.Stop();
            Message.Text = "";
            orderNumberButton.Visible = true;
            receiptButton.Visible = true;
            cancelButton.Visible = false;
        }

        private void timer2_Tick(object? sender, EventArgs e)
        {
            timer2.Stop();
            Message.Text = $"카드 투입구에서 카드를 가져가세요.";

            // 4초 후에 실행될 타이머를 설정
            Timer delayTimer = new Timer();
            delayTimer.Interval = 4000; // 4초
            delayTimer.Tick += (s, ev) =>
            {
                // 이 부분은 타이머 시작후 4초 후에 실행됩니다.
                Message.Text = "";
                orderNumberButton.Visible = true;
                receiptButton.Visible = true;
                delayTimer.Stop(); // 타이머를 중지
            };
            delayTimer.Start(); // 타이머를 시작

            cancelButton.Visible = false;
        }

        private void timer3_Tick(object? sender, EventArgs e)
        {
            timer3.Stop();
            orderNumberButton.Visible = true;
            receiptButton.Visible = true;
            cancelButton.Visible = false;
        }
        private void timer4_Tick(object? sender, EventArgs e)
        {
            timer4.Stop();
            CancelStatus();
            form2.ResetForm();
            this.Close();
        }

        // 현금 버튼 클릭 함수
        private void cashbutton_Click(object sender, EventArgs e)
        {
            cashbutton.Visible = true;
            Message.Visible = true;
            cancelButton.Visible = true;
            paymentMethod = "현금";
            Message.Text = "현금을 투입해주세요 ";
            status = 1; // 현금 결제시 받은돈과 거스름돈 출력을 위해 status 변수사용

            cash_button.Visible = true;
            cash_input.Visible = true;

        }

        // 카드 버튼 클릭 함수
        private void cardbutton_Click(object sender, EventArgs e)
        {
            Message.Visible = true;
            cancelButton.Visible = true;
            status = 0;
            paymentMethod = "카드";
            Message.Text = "카드를 투입해주세요 ";
            timer2.Start();
        }

        // 쿠폰 버튼 클릭 함수
        private void couponbutton_Click(object sender, EventArgs e)
        {
            Message.Visible = true;
            cancelButton.Visible = true;
            status = 0;
            paymentMethod = "쿠폰";
            Message.Text = "쿠폰을 리더기에 스캔해주세요 ";
            timer3.Start();
        }

        // 주문 번호만 출력
        private void orderNumberButton_Click(object sender, EventArgs e)
        {
            orderNumberButton.Visible = false;
            receiptButton.Visible = false;
            Message.Text = $"{ticketNumber}번 번호표를 받아가주세요";
            ticketNumber++;
            timer4.Start();
        }

        // 현금 입력 후 버튼 클릭시 사용되는 함수
        private void cash_button_Click(object sender, EventArgs e)
        {
            // 사용자가 입력한 금액을 가져옴
            string cashInputWithoutWon = cash_input.Text.Replace("원", "").Trim();
            if (int.TryParse(cashInputWithoutWon, out cashAmount))
            {
                // 입력한 금액이 총 금액보다 크거나 같은 경우
                if (cashAmount >= totalPriceForm2)
                {
                    // 영수증에 표시할 거스름돈을 계산
                    change = cashAmount - totalPriceForm2;

                    // 입력 성공, 결제 완료 등의 메시지를 표시
                    Message.Text = "결제가 완료되었습니다.";
                    cash_button.Visible = false;
                    cash_input.Visible = false;
                    timer1.Start();
                }
                else
                {
                    // 입력한 금액이 총 금액보다 작은 경우
                    Message.Text = "금액이 부족합니다. 다시 입력해주세요.";
                }
            }
            else
            {
                // 입력한 금액을 숫자로 변환하는 데 실패한 경우
                Message.Text = "올바른 금액을 입력해주세요.";
            }
        }

        // 영수증 출력 버튼 함수
        private void receiptButton_Click(object sender, EventArgs e)
        {
            orderNumberButton.Visible = false;
            receiptButton.Visible = false;

            // 새로운 폼을 생성
            Form receiptForm = new Form();
            receiptForm.BackColor = Color.White;
            receiptForm.Text = "영수증";

            // ListBox에서 아이템을 가져와 영수증에 추가
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 2;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panel.AutoSize = true; // 패널의 크기를 내용에 맞게 자동 조절합니다.

            Label receiptLabel = new Label();
            receiptLabel.Text = $"영수증";
            receiptLabel.Dock = DockStyle.Fill;
            receiptLabel.TextAlign = ContentAlignment.MiddleCenter;
            receiptLabel.Font = new Font(receiptLabel.Font.FontFamily, 20, FontStyle.Bold);
            receiptLabel.AutoSize = true; // AutoSize 속성을 true로 설정합니다.
            receiptLabel.Padding = new Padding(10); // Padding 속성을 사용하여 내부 여백을 조절합니다.
            panel.Controls.Add(receiptLabel, 0, panel.RowCount);
            panel.SetColumnSpan(receiptLabel, 2);
            panel.SetRowSpan(receiptLabel, 2); // receiptLabel이 2개의 행을 차지하도록 설정합니다.
            panel.RowCount += 2; // 다음에 추가될 컨트롤이 3번째 행부터 시작하도록 설정합니다.

            Label receiptLabel2 = new Label();
            receiptLabel2.Text = "품목";
            receiptLabel2.TextAlign = ContentAlignment.MiddleLeft;
            receiptLabel2.AutoSize = false;
            receiptLabel2.Dock = DockStyle.Fill;

            Label receiptLabel3 = new Label();
            receiptLabel3.Text = "금액";
            receiptLabel3.TextAlign = ContentAlignment.MiddleRight;
            receiptLabel3.AutoSize = false;
            receiptLabel3.Dock = DockStyle.Fill;
            panel.Controls.Add(receiptLabel2, 0, panel.RowCount);
            panel.Controls.Add(receiptLabel3, 1, panel.RowCount);
            panel.RowCount++;

            Label spaceLabel2 = new Label();
            spaceLabel2.Text = "───────────────────────────────────────────────────────";
            spaceLabel2.Dock = DockStyle.Fill;
            spaceLabel2.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(spaceLabel2, 0, panel.RowCount++);
            panel.SetColumnSpan(spaceLabel2, 2);

            foreach (ListViewItem item in SelectedMenuList.Items)
            {
                Label label1 = new Label();
                label1.Text = item.Text;
                label1.TextAlign = ContentAlignment.MiddleLeft;
                label1.AutoSize = false; // AutoSize 속성을 false로 설정합니다.
                label1.Dock = DockStyle.Fill; // Dock 속성을 Fill로 설정합니다.

                Label label2 = new Label();
                label2.Text = item.SubItems[1].Text;
                label2.TextAlign = ContentAlignment.MiddleRight;
                label2.AutoSize = false; // AutoSize 속성을 false로 설정합니다.
                label2.Dock = DockStyle.Fill; // Dock 속성을 Fill로 설정합니다.

                panel.Controls.Add(label1, 0, panel.RowCount);
                panel.Controls.Add(label2, 1, panel.RowCount);

                panel.RowCount++;
            }

            Label spaceLabel1 = new Label();
            spaceLabel1.Text = "───────────────────────────────────────────────────────";
            spaceLabel1.Dock = DockStyle.Fill;
            spaceLabel1.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(spaceLabel1, 0, panel.RowCount++);
            panel.SetColumnSpan(spaceLabel1, 2);

            // 영수증 정보를 추가
            Label totalLabel1 = new Label();
            totalLabel1.Text = $"합계 가격:\t{totalPriceForm2}원";
            totalLabel1.Dock = DockStyle.Fill;
            totalLabel1.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(totalLabel1, 0, panel.RowCount++);
            panel.SetColumnSpan(totalLabel1, 2);
            if(status == 1) // 현금 결제시 받은돈과 거스름돈 출력을 위해 status 변수사용
            {
                Label cashLabel = new Label();
                cashLabel.Text = $"받은 돈:\t{cashAmount}원";
                cashLabel.Dock = DockStyle.Fill;
                cashLabel.TextAlign = ContentAlignment.MiddleLeft;
                panel.Controls.Add(cashLabel, 0, panel.RowCount++);
                panel.SetColumnSpan(cashLabel, 2);

                Label changeLabel = new Label();
                changeLabel.Text = $"거스름 돈:\t{change}원";
                changeLabel.Dock = DockStyle.Fill;
                changeLabel.TextAlign = ContentAlignment.MiddleLeft;
                panel.Controls.Add(changeLabel, 0, panel.RowCount++);
                panel.SetColumnSpan(changeLabel, 2);  
            }

            Label OrderLabel = new Label();
            OrderLabel.Text = $"주문 정보: {Form1.Global.ORDER} 주문";
            OrderLabel.Dock = DockStyle.Fill;
            OrderLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(OrderLabel, 0, panel.RowCount++);
            panel.SetColumnSpan(OrderLabel, 2);

            Label methodLabel = new Label();
            methodLabel.Text = $"결제 방법: {paymentMethod} 결제";
            methodLabel.Dock = DockStyle.Fill;
            methodLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(methodLabel, 0, panel.RowCount++);
            panel.SetColumnSpan(methodLabel, 2);

            Label ticketLabel = new Label();
            ticketLabel.Text = $"주문 번호: {ticketNumber}번";
            ticketLabel.Dock = DockStyle.Fill;
            ticketLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(ticketLabel, 0, panel.RowCount++);
            panel.SetColumnSpan(ticketLabel, 2);

            receiptForm.Controls.Add(panel);

            // 폼의 크기를 패널의 크기에 맞게 조절합니다.
            receiptForm.ClientSize = panel.Size;
            receiptForm.FormClosed += (s, ev) => timer4.Start();

            receiptForm.Show();


            ticketNumber++;
            Message.Text = "주문이 완료되었습니다.";
        }

        // 취소버튼 로직
        private void CancelStatus()
        {
            // 결제 상태를 초기 상태로 변경하는 로직을 추가
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            Message.Text = string.Empty;
            Message.Visible = false;
            cancelButton.Visible = false;
        }
        // 취소 버튼 클릭 함수
        private void cancleButton_Click(object sender, EventArgs e)
        {
            CancelStatus();

        }
        // 현금입력 다시 할수있게 사용되는 함수
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
