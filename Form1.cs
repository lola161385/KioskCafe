namespace KioskCafe
{
    public partial class Form1 : Form
    {
        //다른 폼에 선택된 값 넘겨주기위한 프로젝트 전역변수
        public static class Global
        {
            public static string ORDER = "";
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        // 매장 버튼 클릭시 발생하는 이벤트 처리
        private void btnDineln_Click(object sender, EventArgs e)
        {
            Global.ORDER = "매장";
            string currentOrder = Global.ORDER;
            OpenForm2("매장");
        }

        // 포장 버튼 클릭시 발생하는 이벤트 처리
        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            Global.ORDER = "포장";
            string currentOrder = Global.ORDER;
            OpenForm2("포장");
        }

        // 폼2 여는 함수
        private void OpenForm2(string orderType)
        {
            // Form1을 숨기고 Form2가 열림
            this.Hide();
            Form2 newForm2 = new Form2(orderType);
            newForm2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            newForm2.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form2가 닫히면 Form1이 다시 열림
            this.Show();
        }
        
    }
}