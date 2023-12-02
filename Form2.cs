using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace KioskCafe
{
    public partial class Form2 : Form
    {
        private int Topping = 0;    // 카테고리별 폼을 나누기위해 form2 전역변수 지정
        private string orderType;   // form1에서 매장인지 포장인지 알수있게 값을 받아오는 form2 전역변수
        public Form2(string orderType)
        {
            InitializeComponent();
            this.orderType = orderType;     // form1에서 넘겨준 값을 저장함
            orderType1.Text = orderType;    // ordeType1
            orderType1.ReadOnly = true;     // textbox는 앱 실행시 클릭으로 값을 수정할수있기에 읽기전용으로
            totalPrice.ReadOnly = true;
        }

        // 메뉴가 늘어 날때 마다 변수는 추가 시켜야함
        int price_1 = 0, price_2 = 0, price_3 = 0, price_4 = 0, price_5 = 0, price_6 = 0, price_7 = 0, price_8 = 0, price_9 = 0, price_10 = 0, price_11 = 0, price_12 = 0, totalprice = 0;

        // 합계 증가시켜주는 함수
        public void addTotalPrice(int price) 
        {
            totalprice += price;
            totalPrice.Text = (totalprice.ToString() + " 원"); //가격 표기 초기화
        }
        // 합계 감소시켜주는 함수
        public void minusTotalPrice(int price)
        {
            totalprice -= price;
            totalPrice.Text = (totalprice.ToString() + " 원");
        }
        // 토핑 추가시 리스트에 보여지게 하는 함수
        public void AddTopping(ListViewItem lvi)
        {
            listView1.Items.Add(lvi);
        }
        public struct Menu
        {

            public string name;  // 해당 메뉴의 이름
            public int price;  // 해당 메뉴의 가격       

            public Menu(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

        }

        // 커피 메뉴 정보
        Menu coffee1 = new Menu("아메리카노", 4000);
        Menu coffee2 = new Menu("카페라떼", 4500);
        Menu coffee3 = new Menu("바닐라라떼", 4500);
        Menu coffee4 = new Menu("민트카페모카", 4500);
        Menu coffee5 = new Menu("콜드브루", 4000);
        Menu coffee6 = new Menu("콜드브루라떼", 4500);
        Menu coffee7 = new Menu("디카페인", 4000);
        Menu coffee8 = new Menu("카라멜마끼아또", 5000);
        Menu coffee9 = new Menu("아포카토", 8000);
        Menu coffee10 = new Menu("쌍화차", 5000);
        Menu coffee11 = new Menu("녹차라떼", 4500);
        Menu coffee12 = new Menu("아인슈페너", 6000);

        // 스무디 메뉴 정보
        Menu smoothie1 = new Menu("딸기스무디", 4000);
        Menu smoothie2 = new Menu("망고스무디", 4000);
        Menu smoothie3 = new Menu("수박스무디", 5000);
        Menu smoothie4 = new Menu("요거트스무디", 5000);
        Menu smoothie5 = new Menu("오렌지스무디", 5000);
        Menu smoothie6 = new Menu("포도스무디", 5000);
        Menu smoothie7 = new Menu("블루베리프라페", 5000);
        Menu smoothie8 = new Menu("딸기프라페", 6000);
        Menu smoothie9 = new Menu("바나나프라페", 6000);
        Menu smoothie10 = new Menu("초코프라페", 6000);
        Menu smoothie11 = new Menu("커피프라페", 7000);
        Menu smoothie12 = new Menu("녹차프라페", 6000);

        // 디저트 메뉴 정보
        Menu dessert1 = new Menu("치즈케익", 5000);
        Menu dessert2 = new Menu("초코무스케익", 4000);
        Menu dessert3 = new Menu("크로크무슈", 5000);
        Menu dessert4 = new Menu("블루베리베이글", 7000);
        Menu dessert5 = new Menu("플레인베이글", 7000);
        Menu dessert6 = new Menu("잉글리시머핀", 6000);
        Menu dessert7 = new Menu("아이스크림크로플", 8000);
        Menu dessert8 = new Menu("체다치즈크로플", 7000);
        Menu dessert9 = new Menu("레몬 파운드", 6000);
        Menu dessert10 = new Menu("얼그레이 파운드", 5000);
        Menu dessert11 = new Menu("허니브래드", 7000);
        Menu dessert12 = new Menu("소금빵", 5000);


        // 메뉴 초기화 변수를 일일이 초기화하면 코드 길이가 길어져서 for문을사용 48줄에서 15줄로 줄임
        private void menu_initialize()
        {
            Dictionary<string, int> prices = new Dictionary<string, int>();

            for (int i = 1; i <= 12; i++)
            {
                prices["price_" + i] = 0;
                var menuButton = this.Controls.Find("menuButton_" + i, true).FirstOrDefault() as Button;
                var menuPrice = this.Controls.Find("menuPrice_" + i, true).FirstOrDefault() as Label;
                if (menuButton != null)
                {
                    menuButton.Visible = false;
                    menuButton.Text = "";
                }
                if (menuPrice != null)
                {
                    menuPrice.Text = "";
                }
            }
        }

        // 커피 카테고리를 클릭시 모든 메뉴버튼의 정보를 커피로 업데이트 
        private void coffeeSelected()
        {
            Topping = 1;        // 커피 토핑에 대한정보는 Form3에 있기에 status를 1로 설정하여 나중에 if문으로 판단을 위해 변수 설정
            menu_initialize();  //메뉴의 정보를 초기화

            // 커피 메뉴 1                                                   // 메뉴 설정 값 주석 12개씩 3개의 카테고리 모두 동일함으로 첫번째에만 주석 표시
            menuButton_1.Visible = true;                                    // 버튼이 보이게 설정
            menuButton_1.Text = coffee1.name;                               // 버튼의 이름을 구조체에서 설정한 이름
            menuButton_1.BackColor = Color.Transparent;                     // 버튼의 뒷배경을 투명하게 설정
            menuButton_1.BackgroundImageLayout = ImageLayout.Stretch;       // 버튼의 크기에 맞게 배경 이미지를 설정
            menuButton_1.FlatAppearance.BorderSize = 0;                     // 테두리를 0으로
            menuButton_1.FlatStyle = FlatStyle.Flat;                        // 테두리에 배경이 채워짐
            menuButton_1.BackgroundImage = Properties.Resources.amaricano;  // 버튼 배경 Resources파일 안에 있는 이미지 사용
            menuPrice_1.Text = coffee1.price.ToString();                    // 구조체에서 설정한 가격 string으로 변환하여 가격표시
            textBox1.Text = coffee1.name;                                   // 메뉴명 textbox 이름 지정
            price_1 = coffee1.price;                                        // price에 해당 가격값 저장

            // 커피 메뉴 2
            menuButton_2.Visible = true;
            menuButton_2.Text = coffee2.name;
            menuButton_2.BackColor = Color.Transparent;
            menuButton_2.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_2.FlatAppearance.BorderSize = 0;
            menuButton_2.FlatStyle = FlatStyle.Flat;
            menuButton_2.BackgroundImage = Properties.Resources.cafelatte;
            menuPrice_2.Text = coffee2.price.ToString();
            textBox2.Text = coffee2.name;
            price_2 = coffee2.price;

            // 커피 메뉴 3
            menuButton_3.Visible = true;
            menuButton_3.Text = coffee3.name;
            menuButton_3.BackColor = Color.Transparent;
            menuButton_3.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_3.FlatAppearance.BorderSize = 0;
            menuButton_3.FlatStyle = FlatStyle.Flat;
            menuButton_3.BackgroundImage = Properties.Resources.vanillalatte;
            menuPrice_3.Text = coffee3.price.ToString();
            textBox3.Text = coffee3.name;
            price_3 = coffee3.price;

            // 커피 메뉴 4
            menuButton_4.Visible = true;
            menuButton_4.Text = coffee4.name;
            menuButton_4.BackColor = Color.Transparent;
            menuButton_4.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_4.FlatAppearance.BorderSize = 0;
            menuButton_4.FlatStyle = FlatStyle.Flat;
            menuButton_4.BackgroundImage = Properties.Resources.mintmoca1;
            menuPrice_4.Text = coffee4.price.ToString();
            textBox4.Text = coffee4.name;
            price_4 = coffee4.price;

            // 커피 메뉴 5
            menuButton_5.Visible = true;
            menuButton_5.Text = coffee5.name;
            menuButton_5.BackColor = Color.Transparent;
            menuButton_5.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_5.FlatAppearance.BorderSize = 0;
            menuButton_5.FlatStyle = FlatStyle.Flat;
            menuButton_5.BackgroundImage = Properties.Resources.coldbrew;
            menuPrice_5.Text = coffee5.price.ToString();
            textBox5.Text = coffee5.name;
            price_5 = coffee5.price;

            // 커피 메뉴 6
            menuButton_6.Visible = true;
            menuButton_6.Text = coffee6.name;
            menuButton_6.BackColor = Color.Transparent;
            menuButton_6.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_6.FlatAppearance.BorderSize = 0;
            menuButton_6.FlatStyle = FlatStyle.Flat;
            menuButton_6.BackgroundImage = Properties.Resources.coldbrewlatte;
            menuPrice_6.Text = coffee6.price.ToString();
            textBox6.Text = coffee6.name;
            price_6 = coffee6.price;

            // 커피 메뉴 7
            menuButton_7.Visible = true;
            menuButton_7.Text = coffee7.name;
            menuButton_7.BackColor = Color.Transparent;
            menuButton_7.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_7.FlatAppearance.BorderSize = 0;
            menuButton_7.FlatStyle = FlatStyle.Flat;
            menuButton_7.BackgroundImage = Properties.Resources.coldbrewdecafe;
            menuPrice_7.Text = coffee7.price.ToString();
            textBox7.Text = coffee7.name;
            price_7 = coffee7.price;

            // 커피 메뉴 8
            menuButton_8.Visible = true;
            menuButton_8.Text = coffee8.name;
            menuButton_8.BackColor = Color.Transparent;
            menuButton_8.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_8.FlatAppearance.BorderSize = 0;
            menuButton_8.FlatStyle = FlatStyle.Flat;
            menuButton_8.BackgroundImage = Properties.Resources.caramel;
            menuPrice_8.Text = coffee8.price.ToString();
            textBox8.Text = coffee8.name;
            price_8 = coffee8.price;

            // 커피 메뉴 9
            menuButton_9.Visible = true;
            menuButton_9.Text = coffee9.name;
            menuButton_9.BackColor = Color.Transparent;
            menuButton_9.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_9.FlatAppearance.BorderSize = 0;
            menuButton_9.FlatStyle = FlatStyle.Flat;
            menuButton_9.BackgroundImage = Properties.Resources.apocato;
            menuPrice_9.Text = coffee9.price.ToString();
            textBox9.Text = coffee9.name;
            price_9 = coffee9.price;

            // 커피 메뉴 10
            menuButton_10.Visible = true;
            menuButton_10.Text = coffee10.name;
            menuButton_10.BackColor = Color.Transparent;
            menuButton_10.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_10.FlatAppearance.BorderSize = 0;
            menuButton_10.FlatStyle = FlatStyle.Flat;
            menuButton_10.BackgroundImage = Properties.Resources.ssang_removebg;
            menuPrice_10.Text = coffee10.price.ToString();
            textBox10.Text = coffee10.name;
            price_10 = coffee10.price;

            // 커피 메뉴 11
            menuButton_11.Visible = true;
            menuButton_11.Text = coffee11.name;
            menuButton_11.BackColor = Color.Transparent;
            menuButton_11.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_11.FlatAppearance.BorderSize = 0;
            menuButton_11.FlatStyle = FlatStyle.Flat;
            menuButton_11.BackgroundImage = Properties.Resources.greentealatte;
            menuPrice_11.Text = coffee11.price.ToString();
            textBox11.Text = coffee11.name;
            price_11 = coffee11.price;

            // 커피 메뉴 12
            menuButton_12.Visible = true;
            menuButton_12.Text = coffee12.name;
            menuButton_12.BackColor = Color.Transparent;
            menuButton_12.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_12.FlatAppearance.BorderSize = 0;
            menuButton_12.FlatStyle = FlatStyle.Flat;
            menuButton_12.BackgroundImage = Properties.Resources.insupener;
            menuPrice_12.Text = coffee12.price.ToString();
            textBox12.Text = coffee12.name;
            price_12 = coffee12.price;

        }

        // 스무디 카테고리 클릭시 모든 메뉴버튼의 정보를 스무디로 업데이트
        private void smoothieSelected()
        {
            Topping = 2;
            menu_initialize(); // 메뉴 정보를 초기화

            // 스무디 메뉴 1
            menuButton_1.Visible = true;
            menuButton_1.Text = smoothie1.name;
            menuButton_1.BackColor = Color.Transparent;
            menuButton_1.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_1.FlatAppearance.BorderSize = 0;
            menuButton_1.FlatStyle = FlatStyle.Flat;
            menuButton_1.BackgroundImage = Properties.Resources.strawbarry;
            menuPrice_1.Text = smoothie1.price.ToString();
            textBox1.Text = smoothie1.name;
            price_1 = smoothie1.price;

            // 스무디 메뉴 2
            menuButton_2.Visible = true;
            menuButton_2.Text = smoothie2.name;
            menuButton_2.BackColor = Color.Transparent;
            menuButton_2.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_2.FlatAppearance.BorderSize = 0;
            menuButton_2.FlatStyle = FlatStyle.Flat;
            menuButton_2.BackgroundImage = Properties.Resources.manggo;
            menuPrice_2.Text = smoothie2.price.ToString();
            textBox2.Text = smoothie2.name;
            price_2 = smoothie2.price;

            // 스무디 메뉴 3
            menuButton_3.Visible = true;
            menuButton_3.Text = smoothie3.name;
            menuButton_3.BackColor = Color.Transparent;
            menuButton_3.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_3.FlatAppearance.BorderSize = 0;
            menuButton_3.FlatStyle = FlatStyle.Flat;
            menuButton_3.BackgroundImage = Properties.Resources.watermelon;
            menuPrice_3.Text = smoothie3.price.ToString();
            textBox3.Text = smoothie3.name;
            price_3 = smoothie3.price;

            // 스무디 메뉴 4
            menuButton_4.Visible = true;
            menuButton_4.Text = smoothie4.name;
            menuButton_4.BackColor = Color.Transparent;
            menuButton_4.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_4.FlatAppearance.BorderSize = 0;
            menuButton_4.FlatStyle = FlatStyle.Flat;
            menuButton_4.BackgroundImage = Properties.Resources.yogurt;
            menuPrice_4.Text = smoothie4.price.ToString();
            textBox4.Text = smoothie4.name;
            price_4 = smoothie4.price;

            // 스무디 메뉴 5
            menuButton_5.Visible = true;
            menuButton_5.Text = smoothie5.name;
            menuButton_5.BackColor = Color.Transparent;
            menuButton_5.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_5.FlatAppearance.BorderSize = 0;
            menuButton_5.FlatStyle = FlatStyle.Flat;
            menuButton_5.BackgroundImage = Properties.Resources.orange;
            menuPrice_5.Text = smoothie5.price.ToString();
            textBox5.Text = smoothie5.name;
            price_5 = smoothie5.price;

            // 스무디 메뉴 6
            menuButton_6.Visible = true;
            menuButton_6.Text = smoothie6.name;
            menuButton_6.BackColor = Color.Transparent;
            menuButton_6.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_6.FlatAppearance.BorderSize = 0;
            menuButton_6.FlatStyle = FlatStyle.Flat;
            menuButton_6.BackgroundImage = Properties.Resources.grape;
            menuPrice_6.Text = smoothie6.price.ToString();
            textBox6.Text = smoothie6.name;
            price_6 = smoothie6.price;

            // 스무디 메뉴 7
            menuButton_7.Visible = true;
            menuButton_7.Text = smoothie7.name;
            menuButton_7.BackColor = Color.Transparent;
            menuButton_7.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_7.FlatAppearance.BorderSize = 0;
            menuButton_7.FlatStyle = FlatStyle.Flat;
            menuButton_7.BackgroundImage = Properties.Resources.bluebarry;
            menuPrice_7.Text = smoothie7.price.ToString();
            textBox7.Text = smoothie7.name;
            price_7 = smoothie7.price;

            // 스무디 메뉴 8
            menuButton_8.Visible = true;
            menuButton_8.Text = smoothie8.name;
            menuButton_8.BackColor = Color.Transparent;
            menuButton_8.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_8.FlatAppearance.BorderSize = 0;
            menuButton_8.FlatStyle = FlatStyle.Flat;
            menuButton_8.BackgroundImage = Properties.Resources.strawbarrypraffe;
            menuPrice_8.Text = smoothie8.price.ToString();
            textBox8.Text = smoothie8.name;
            price_8 = smoothie8.price;

            // 스무디 메뉴 9
            menuButton_9.Visible = true;
            menuButton_9.Text = smoothie9.name;
            menuButton_9.BackColor = Color.Transparent;
            menuButton_9.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_9.FlatAppearance.BorderSize = 0;
            menuButton_9.FlatStyle = FlatStyle.Flat;
            menuButton_9.BackgroundImage = Properties.Resources.bannanapraffe;
            menuPrice_9.Text = smoothie9.price.ToString();
            textBox9.Text = smoothie9.name;
            price_9 = smoothie9.price;

            // 스무디 메뉴 10
            menuButton_10.Visible = true;
            menuButton_10.Text = smoothie10.name;
            menuButton_10.BackColor = Color.Transparent;
            menuButton_10.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_10.FlatAppearance.BorderSize = 0;
            menuButton_10.FlatStyle = FlatStyle.Flat;
            menuButton_10.BackgroundImage = Properties.Resources.chocopraffe;
            menuPrice_10.Text = smoothie10.price.ToString();
            textBox10.Text = smoothie10.name;
            price_10 = smoothie10.price;

            // 스무디 메뉴 11
            menuButton_11.Visible = true;
            menuButton_11.Text = smoothie11.name;
            menuButton_11.BackColor = Color.Transparent;
            menuButton_11.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_11.FlatAppearance.BorderSize = 0;
            menuButton_11.FlatStyle = FlatStyle.Flat;
            menuButton_11.BackgroundImage = Properties.Resources.caffeepraffe;
            menuPrice_11.Text = smoothie11.price.ToString();
            textBox11.Text = smoothie11.name;
            price_11 = smoothie11.price;

            // 스무디 메뉴 12
            menuButton_12.Visible = true;
            menuButton_12.Text = smoothie12.name;
            menuButton_12.BackColor = Color.Transparent;
            menuButton_12.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_12.FlatAppearance.BorderSize = 0;
            menuButton_12.FlatStyle = FlatStyle.Flat;
            menuButton_12.BackgroundImage = Properties.Resources.greenteapraffe;
            menuPrice_12.Text = smoothie12.price.ToString();
            textBox12.Text = smoothie12.name;
            price_12 = smoothie12.price;

        }

        // 디저트 카테고리 클릭시 모든 메뉴버튼의 정보를 디저트로 업데이트
        private void dessertSelected()
        {
            Topping = 0;
            menu_initialize(); //메뉴의 정보를 초기화

            // 디저트 메뉴 1
            menuButton_1.Visible = true;
            menuButton_1.Text = dessert1.name;
            menuButton_1.BackColor = Color.Transparent;
            menuButton_1.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_1.FlatAppearance.BorderSize = 0;
            menuButton_1.FlatStyle = FlatStyle.Flat;
            menuButton_1.BackgroundImage = Properties.Resources.cheesecake;
            textBox1.Text = dessert1.name;
            menuPrice_1.Text = dessert1.price.ToString();
            price_1 = dessert1.price;

            // 디저트 메뉴 2
            menuButton_2.Visible = true;
            menuButton_2.Text = dessert2.name;
            menuButton_2.BackColor = Color.Transparent;
            menuButton_2.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_2.FlatAppearance.BorderSize = 0;
            menuButton_2.FlatStyle = FlatStyle.Flat;
            menuButton_2.BackgroundImage = Properties.Resources.chocomusecake;
            textBox2.Text = dessert2.name;
            menuPrice_2.Text = dessert2.price.ToString();
            price_2 = dessert2.price;

            // 디저트 메뉴 3
            menuButton_3.Visible = true;
            menuButton_3.Text = dessert3.name;
            menuButton_3.BackColor = Color.Transparent;
            menuButton_3.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_3.FlatAppearance.BorderSize = 0;
            menuButton_3.FlatStyle = FlatStyle.Flat;
            menuButton_3.BackgroundImage = Properties.Resources.crokmusu;
            textBox3.Text = dessert3.name;
            menuPrice_3.Text = dessert3.price.ToString();
            price_3 = dessert3.price;

            // 디저트 메뉴 4
            menuButton_4.Visible = true;
            menuButton_4.Text = dessert4.name;
            menuButton_4.BackColor = Color.Transparent;
            menuButton_4.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_4.FlatAppearance.BorderSize = 0;
            menuButton_4.FlatStyle = FlatStyle.Flat;
            menuButton_4.BackgroundImage = Properties.Resources.bluebarrybagle;
            textBox4.Text = dessert4.name;
            menuPrice_4.Text = dessert4.price.ToString();
            price_4 = dessert4.price;

            // 디저트 메뉴 5
            menuButton_5.Visible = true;
            menuButton_5.Text = dessert5.name;
            menuButton_5.BackColor = Color.Transparent;
            menuButton_5.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_5.FlatAppearance.BorderSize = 0;
            menuButton_5.FlatStyle = FlatStyle.Flat;
            menuButton_5.BackgroundImage = Properties.Resources.plainbagle;
            textBox5.Text = dessert5.name;
            menuPrice_5.Text = dessert5.price.ToString();
            price_5 = dessert5.price;

            // 디저트 메뉴 6
            menuButton_6.Visible = true;
            menuButton_6.Text = dessert6.name;
            menuButton_6.BackColor = Color.Transparent;
            menuButton_6.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_6.FlatAppearance.BorderSize = 0;
            menuButton_6.FlatStyle = FlatStyle.Flat;
            menuButton_6.BackgroundImage = Properties.Resources.englishmurfin;
            textBox6.Text = dessert6.name;
            menuPrice_6.Text = dessert6.price.ToString();
            price_6 = dessert6.price;

            // 디저트 메뉴 7
            menuButton_7.Visible = true;
            menuButton_7.Text = dessert7.name;
            menuButton_7.BackColor = Color.Transparent;
            menuButton_7.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_7.FlatAppearance.BorderSize = 0;
            menuButton_7.FlatStyle = FlatStyle.Flat;
            menuButton_7.BackgroundImage = Properties.Resources.isecreamcrople;
            textBox7.Text = dessert7.name;
            menuPrice_7.Text = dessert7.price.ToString();
            price_7 = dessert7.price;

            // 디저트 메뉴 8
            menuButton_8.Visible = true;
            menuButton_8.Text = dessert8.name;
            menuButton_8.BackColor = Color.Transparent;
            menuButton_8.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_8.FlatAppearance.BorderSize = 0;
            menuButton_8.FlatStyle = FlatStyle.Flat;
            menuButton_8.BackgroundImage = Properties.Resources.chaedacheese;
            textBox8.Text = dessert8.name;
            menuPrice_8.Text = dessert8.price.ToString();
            price_8 = dessert8.price;

            // 디저트 메뉴 9
            menuButton_9.Visible = true;
            menuButton_9.Text = dessert9.name;
            menuButton_9.BackColor = Color.Transparent;
            menuButton_9.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_9.FlatAppearance.BorderSize = 0;
            menuButton_9.FlatStyle = FlatStyle.Flat;
            menuButton_9.BackgroundImage = Properties.Resources.lemonpound;
            textBox9.Text = dessert9.name;
            menuPrice_9.Text = dessert9.price.ToString();
            price_9 = dessert9.price;

            // 디저트 메뉴 10
            menuButton_10.Visible = true;
            menuButton_10.Text = dessert10.name;
            menuButton_10.BackColor = Color.Transparent;
            menuButton_10.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_10.FlatAppearance.BorderSize = 0;
            menuButton_10.FlatStyle = FlatStyle.Flat;
            menuButton_10.BackgroundImage = Properties.Resources.algraypound;
            textBox10.Text = dessert10.name;
            menuPrice_10.Text = dessert10.price.ToString();
            price_10 = dessert10.price;

            // 디저트 메뉴 11
            menuButton_11.Visible = true;
            menuButton_11.Text = dessert11.name;
            menuButton_11.BackColor = Color.Transparent;
            menuButton_11.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_11.FlatAppearance.BorderSize = 0;
            menuButton_11.FlatStyle = FlatStyle.Flat;
            menuButton_11.BackgroundImage = Properties.Resources.honeybread;
            textBox11.Text = dessert11.name;
            menuPrice_11.Text = dessert11.price.ToString();
            price_11 = dessert11.price;

            // 디저트 메뉴 12
            menuButton_12.Visible = true;
            menuButton_12.Text = dessert12.name;
            menuButton_12.BackColor = Color.Transparent;
            menuButton_12.BackgroundImageLayout = ImageLayout.Stretch;
            menuButton_12.FlatAppearance.BorderSize = 0;
            menuButton_12.FlatStyle = FlatStyle.Flat;
            menuButton_12.BackgroundImage = Properties.Resources.saltbread;
            textBox12.Text = dessert12.name;
            menuPrice_12.Text = dessert12.price.ToString();
            price_12 = dessert12.price;

        }

        // 메뉴 카테고리 선택 버튼

        private void button_selectCoffee(object sender, EventArgs e) // 커피 카테고리 선택 버튼
        {
            Button button = (Button)sender;
            button.BackColor = Color.MediumPurple;          // 클릭된 버튼의 배경색을 보라색으로 변경
            smoothieButton.BackColor = Color.MediumOrchid;  // 다른 버튼의 배경색을 흰색으로 변경
            dessertButton.BackColor = Color.MediumOrchid;   // 다른 버튼의 배경색을 흰색으로 변경
            coffeeSelected();
        }

        private void button_selectSmoothie(object sender, EventArgs e) // 음료 카테고리 선택 버튼
        {
            Button button = (Button)sender;
            button.BackColor = Color.MediumPurple;          // 클릭된 버튼의 배경색을 보라색으로 변경
            coffeeButton.BackColor = Color.MediumOrchid;    // 다른 버튼의 배경색을 흰색으로 변경
            dessertButton.BackColor = Color.MediumOrchid;   // 다른 버튼의 배경색을 흰색으로 변경
            smoothieSelected();
        }
        private void button_selectDessert(object sender, EventArgs e) // 디저트 카테고리 선택 버튼
        {
            Button button = (Button)sender;
            button.BackColor = Color.MediumPurple;          // 클릭된 버튼의 배경색을 보라색으로 변경
            coffeeButton.BackColor = Color.MediumOrchid;    // 다른 버튼의 배경색을 흰색으로 변경
            smoothieButton.BackColor = Color.MediumOrchid;  // 다른 버튼의 배경색을 흰색으로 변경
            dessertSelected();
        }

        // 메뉴 선택 버튼 (1~12)
        // 1                                                                // 12개 버튼 모두 동일함으로 첫번째만 설명
        private void button_selectMenu_1(object sender, EventArgs e)        // 메뉴 클릭시 작동하는 함수
        {
            ListViewItem lvi = new ListViewItem();                          // listview 도구를 사용해서 품목과 값이 한 행을 차지
            lvi.Text = menuButton_1.Text;                                   // listview 열의 첫번째 값을 버튼의 텍스트 값 저장
            lvi.SubItems.Add(menuPrice_1.Text);                             // listview 열의 두번째 값을 가격의 텍스트 값 저장
            ListViewGroup group = new ListViewGroup(menuButton_1.Text);     // listview를 그룹화 시켜서 메뉴 삭제시 토핑도 한번에 지울수있게 그룹화
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);                                       // listview에 값을 추가
            addTotalPrice(price_1);                                         // 총 가격에 가격을 추가
            // Form2에 전역변수로 status를 처리하는 기능
            if (Topping == 1)                                               // 1일경우에는 커피로 인식해서 커피에대한 토핑 form3 실행
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)                                          // 2일 경우에는 스무디로 인식해서 스무디에대한 토핑 form5 실행
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        // 2
        private void button_selectMenu_2(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_2.Text;
            lvi.SubItems.Add(menuPrice_2.Text);
            ListViewGroup group = new ListViewGroup(menuButton_2.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_2);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        // 3
        private void button_selectMenu_3(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_3.Text;
            lvi.SubItems.Add(menuPrice_3.Text);
            ListViewGroup group = new ListViewGroup(menuButton_3.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_3);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        // 4
        private void button_selectMenu_4(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_4.Text;
            lvi.SubItems.Add(menuPrice_4.Text);
            ListViewGroup group = new ListViewGroup(menuButton_4.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_4);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        // 5
        private void button_selectMenu_5(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_5.Text;
            lvi.SubItems.Add(menuPrice_5.Text);
            ListViewGroup group = new ListViewGroup(menuButton_5.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_5);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        // 6
        private void button_selectMenu_6(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_6.Text;
            lvi.SubItems.Add(menuPrice_6.Text);
            ListViewGroup group = new ListViewGroup(menuButton_6.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_6);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        private void button_selectMenu_7(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_7.Text;
            lvi.SubItems.Add(menuPrice_7.Text);
            ListViewGroup group = new ListViewGroup(menuButton_7.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_7);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        private void button_selectMenu_8(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_8.Text;
            lvi.SubItems.Add(menuPrice_8.Text);
            ListViewGroup group = new ListViewGroup(menuButton_8.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_8);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        private void button_selectMenu_9(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_9.Text;
            lvi.SubItems.Add(menuPrice_9.Text);
            ListViewGroup group = new ListViewGroup(menuButton_9.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_9);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        private void button_selectMenu_10(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_10.Text;
            lvi.SubItems.Add(menuPrice_10.Text);
            ListViewGroup group = new ListViewGroup(menuButton_10.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_10);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        private void button_selectMenu_11(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_11.Text;
            lvi.SubItems.Add(menuPrice_11.Text);
            ListViewGroup group = new ListViewGroup(menuButton_11.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_11);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        private void button_selectMenu_12(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = menuButton_12.Text;
            lvi.SubItems.Add(menuPrice_12.Text);
            ListViewGroup group = new ListViewGroup(menuButton_12.Text);
            listView1.Groups.Add(group);
            lvi.Group = group;
            listView1.Items.Add(lvi);
            addTotalPrice(price_12);
            if (Topping == 1)
            {
                Form form3 = new Form3(this, group);
                form3.Show();
            }
            else if (Topping == 2)
            {
                Form form5 = new Form5(this, group);
                form5.Show();
            }
        }

        // 폼이 처음 로드 되었을 때 자동으로 처리하는 함수
        private void Form2_Load(object sender, EventArgs e)
        {

            totalPrice.Text = (totalprice.ToString() + " 원");               // 총 가격 표기 초기화
            menu_initialize();                                               // 메뉴를 우선 초기화
            coffeeSelected();                                                // 기본으로 커피 카테고리가 보이게

            listView1.Columns.Add("품목", 100, HorizontalAlignment.Left);     // listview 첫번째 열 지정
            listView1.Columns.Add("금액", 50, HorizontalAlignment.Left);      // listview 두번째 열 지정
        }

        // 뒤로 가기 버튼 눌렀을때 처음 화면으로 가기위한 함수
        private void Form1_Load(object sender, EventArgs e) // 폼이 처음 로드 되었을 때
        {
            this.Hide();                                    // 현재 Form2 숨김
            Form1 newForm1 = new Form1();                   
            newForm1.ShowDialog();                          // 새로운 form1 보이기
        }
        
        // 결제 까지 완료됬을경우 초기화면으로 가기위한 reset 함수
        public void ResetForm()
        {
            menu_initialize();                                   // 메뉴 초기화
            totalprice = 0;                                      // totalprice = 0; 으로 초기화
            totalPrice.Text = (totalprice.ToString() + " 원");   // 텍스트값 초기화
            coffeeSelected();                                    // 커피카테고리가 처음 화면에서 보이게
            listView1.Items.Clear();                             // ListView초기화
            this.Hide();                                         // 현재 켜져있는 폼 숨김
            Form form1 = new Form1();
            form1.Show();                                        // 기본인 form1 보이기
        }

        // 결제 버튼 클릭 함수
        private void purchase_Button_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.TotalPriceForm4 = totalprice;                   // 총가격 넘겨주기
            form4.ShowDialog();                                   // form4 보이기
        }

        // 매뉴 제거 버튼 클릭 함수
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];

                if (selectedItem.Text.StartsWith("ㄴ"))                          // 토핑 항목인 경우 토핑만 삭제
                {
                    int price = int.Parse(selectedItem.SubItems[1].Text);
                    minusTotalPrice(price);
                    listView1.Items.Remove(selectedItem);
                }
                else                                                             // 메뉴 항목인 경우 해당 토핑까지 모두 삭제
                {
                    ListViewGroup group = selectedItem.Group;
                    List<ListViewItem> itemsToRemove = new List<ListViewItem>();

                    foreach (ListViewItem item in group.Items)
                    {
                        int price = int.Parse(item.SubItems[1].Text);
                        minusTotalPrice(price);
                        itemsToRemove.Add(item);
                    }

                    foreach (ListViewItem item in itemsToRemove)
                    {
                        listView1.Items.Remove(item);
                    }

                    listView1.Groups.Remove(group);
                }
            }
        }

        // 아래 3개의 함수는 변경될대 발생하는 이벤트를 처리하는 메서드임  예를 들어, 사용자가 텍스트 박스에 텍스트를 입력하거나 변경하면 이 메서드가 호출됨
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void menuPrice_7_TextChanged(object sender, EventArgs e)
        {
        }

        private void orderType1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
