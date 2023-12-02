namespace KioskCafe
{
    public partial class Form1 : Form
    {
        //�ٸ� ���� ���õ� �� �Ѱ��ֱ����� ������Ʈ ��������
        public static class Global
        {
            public static string ORDER = "";
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        // ���� ��ư Ŭ���� �߻��ϴ� �̺�Ʈ ó��
        private void btnDineln_Click(object sender, EventArgs e)
        {
            Global.ORDER = "����";
            string currentOrder = Global.ORDER;
            OpenForm2("����");
        }

        // ���� ��ư Ŭ���� �߻��ϴ� �̺�Ʈ ó��
        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            Global.ORDER = "����";
            string currentOrder = Global.ORDER;
            OpenForm2("����");
        }

        // ��2 ���� �Լ�
        private void OpenForm2(string orderType)
        {
            // Form1�� ����� Form2�� ����
            this.Hide();
            Form2 newForm2 = new Form2(orderType);
            newForm2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            newForm2.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form2�� ������ Form1�� �ٽ� ����
            this.Show();
        }
        
    }
}