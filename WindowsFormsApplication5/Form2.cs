using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {

        public int sumValue = 0;
        int identi = 0;

        Form6 f6 = new Form6();

        public Form2()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //폼 초기화 부분
            //프로그램 시작시 작동함

            c1_Menu_1.Visible = true;                                   //시작시 카테고리1의 메뉴를 표시함
            c1_Menu_2.Visible = true;
            c1_Menu_3.Visible = true;
            c1_Menu_4.Visible = true;
            c1_Menu_5.Visible = true;
            c1_Menu_6.Visible = true;
            c1_Menu_7.Visible = true;
            c1_Menu_8.Visible = true;

            c2_Menu_1.Visible = false;
            c2_Menu_2.Visible = false;
            c2_Menu_3.Visible = false;
            c2_Menu_4.Visible = false;
            c2_Menu_5.Visible = false;

            c3_Menu_1.Visible = false;
            c3_Menu_2.Visible = false;
            c3_Menu_3.Visible = false;
            c3_Menu_4.Visible = false;
            c3_Menu_5.Visible = false;
            c3_Menu_6.Visible = false;
            c3_Menu_7.Visible = false;


            c1_Menu_1.Text = "아메리카노\n2800";
            c1_Menu_2.Text = "카페 라떼\n3200";
            c1_Menu_3.Text = "카페 모카\n3500";
            c1_Menu_4.Text = "마끼아또\n3500";
            c1_Menu_5.Text = "카푸치노\n3200";
            c1_Menu_6.Text = "바닐라 라떼\n3500";
            c1_Menu_7.Text = "초콜릿 모카\n3500";
            c1_Menu_8.Text = "민트 모카\n3800";

            c2_Menu_1.Text = "아이스티\n2500";
            c2_Menu_2.Text = "에이드\n3800";
            c2_Menu_3.Text = "버블티\n4200";
            c2_Menu_4.Text = "과일주스\n4200";
            c2_Menu_5.Text = "밀크 쉐이크\n4500";

            c3_Menu_1.Text = "페스트리 슈\n2000";
            c3_Menu_2.Text = "에끌레어\n2500";
            c3_Menu_3.Text = "스노우 쿠키슈\n1800";
            c3_Menu_4.Text = "초코칩 머핀\n2000";
            c3_Menu_5.Text = "플레인 베이글\n1900";
            c3_Menu_6.Text = "치킨 치아바타\n3900";
            c3_Menu_7.Text = "카라멜 브레드\n4600";


        }

        private void categori_1_Click(object sender, EventArgs e)
        {
            //카테고리 1 버튼 클릭 시 작동
            //카테고리 1의 메뉴를 표시
            c1_Menu_1.Visible = true;
            c1_Menu_2.Visible = true;
            c1_Menu_3.Visible = true;
            c1_Menu_4.Visible = true;
            c1_Menu_5.Visible = true;
            c1_Menu_6.Visible = true;
            c1_Menu_7.Visible = true;
            c1_Menu_8.Visible = true;

            c2_Menu_1.Visible = false;
            c2_Menu_2.Visible = false;
            c2_Menu_3.Visible = false;
            c2_Menu_4.Visible = false;
            c2_Menu_5.Visible = false;

            c3_Menu_1.Visible = false;
            c3_Menu_2.Visible = false;
            c3_Menu_3.Visible = false;
            c3_Menu_4.Visible = false;
            c3_Menu_5.Visible = false;
            c3_Menu_6.Visible = false;
            c3_Menu_7.Visible = false;
        }

        private void categori_2_Click(object sender, EventArgs e)
        {
            //카테고리 2 버튼 클릭 시 작동
            //카테고리2의 메뉴를 표시
            c1_Menu_1.Visible = false;
            c1_Menu_2.Visible = false;
            c1_Menu_3.Visible = false;
            c1_Menu_4.Visible = false;
            c1_Menu_5.Visible = false;
            c1_Menu_6.Visible = false;
            c1_Menu_7.Visible = false;
            c1_Menu_8.Visible = false;

            c2_Menu_1.Visible = true;
            c2_Menu_2.Visible = true;
            c2_Menu_3.Visible = true;
            c2_Menu_4.Visible = true;
            c2_Menu_5.Visible = true;


            c3_Menu_1.Visible = false;
            c3_Menu_2.Visible = false;
            c3_Menu_3.Visible = false;
            c3_Menu_4.Visible = false;
            c3_Menu_5.Visible = false;
            c3_Menu_6.Visible = false;
            c3_Menu_7.Visible = false;
        }

        private void categori_3_Click(object sender, EventArgs e)
        {
            //카테고리 3 버튼 클릭 시 작동
            //카테고리 3의 메뉴를 표시
            c1_Menu_1.Visible = false;
            c1_Menu_2.Visible = false;
            c1_Menu_3.Visible = false;
            c1_Menu_4.Visible = false;
            c1_Menu_5.Visible = false;
            c1_Menu_6.Visible = false;
            c1_Menu_7.Visible = false;
            c1_Menu_8.Visible = false;

            c2_Menu_1.Visible = false;
            c2_Menu_2.Visible = false;
            c2_Menu_3.Visible = false;
            c2_Menu_4.Visible = false;
            c2_Menu_5.Visible = false;

            c3_Menu_1.Visible = true;
            c3_Menu_2.Visible = true;
            c3_Menu_3.Visible = true;
            c3_Menu_4.Visible = true;
            c3_Menu_5.Visible = true;
            c3_Menu_6.Visible = true;
            c3_Menu_7.Visible = true;

        }


        //카테고리 1의 메뉴
        private void c1_Menu_1_Click(object sender, EventArgs e)
        {
            String[] menu = { "아메리카노", "1", "2800" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c1_Menu_2_Click(object sender, EventArgs e)
        {
            String[] menu = { "카페 라뗴", "1", "3200" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c1_Menu_3_Click(object sender, EventArgs e)
        {
            String[] menu = { "카페 모카", "1", "3500" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c1_Menu_4_Click(object sender, EventArgs e)
        {
            String[] menu = { "카라멜 마끼야또", "1", "3500" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c1_Menu_5_Click(object sender, EventArgs e)
        {
            String[] menu = { "카푸치노", "1", "3200" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c1_Menu_6_Click(object sender, EventArgs e)
        {
            String[] menu = { "바닐라 라뗴", "1", "3500" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c1_Menu_7_Click(object sender, EventArgs e)
        {
            String[] menu = { "초코렛 모카", "1", "3500" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c1_Menu_8_Click(object sender, EventArgs e)
        {
            String[] menu = { "민트 모카", "1", "3800" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }


        //카테고리 2의 메뉴
        private void c2_Menu_1_Click(object sender, EventArgs e)
        {
            String[] menu = { "아이스티", "1", "2500" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c2_Menu_2_Click(object sender, EventArgs e)
        {
            String[] menu = { "에이드", "1", "3800" };
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c2_Menu_3_Click(object sender, EventArgs e)
        {
            String[] menu = { "버블티", "1", "4200" };                //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c2_Menu_4_Click(object sender, EventArgs e)
        {
            String[] menu = { "과일주스", "1", "4200" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c2_Menu_5_Click(object sender, EventArgs e)
        {
            String[] menu = { "밀크 쉐이크", "1", "4500" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }




        //카테고리 3의 메뉴
        private void c3_Menu_1_Click(object sender, EventArgs e)
        {
            String[] menu = { "페스트리 슈", "1", "2000" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c3_Menu_2_Click(object sender, EventArgs e)
        {
            String[] menu = { "에끌레어", "1", "2500" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c3_Menu_3_Click(object sender, EventArgs e)
        {
            String[] menu = { "스노우 쿠키슈", "1", "1800" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c3_Menu_4_Click(object sender, EventArgs e)
        {
            String[] menu = { "초코칩 머핀", "1", "2000" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c3_Menu_5_Click(object sender, EventArgs e)
        {
            String[] menu = { "플레인 베이글", "1", "1900" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c3_Menu_6_Click(object sender, EventArgs e)
        {
            String[] menu = { "치킨 치아바타", "1", "3900" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }

        private void c3_Menu_7_Click(object sender, EventArgs e)
        {
            String[] menu = { "카라멜 브레드", "1", "4600" };               //순서대로 메뉴이름, 수량, 가격
            ListViewItem addMenu = new ListViewItem(menu);
            if (comparision(addMenu))                               //리스트에 이미 항목이 있으면 false, 없으면 true가 반환 
            {
                list.Items.Add(addMenu);
            }
            sum();
        }


        private void Shutdown_Click(object sender, EventArgs e)
        {
            //종료 버튼
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();

        }

        private void select_Cancel_Click(object sender, EventArgs e)
        {
            //선택 되어잇는 항목 삭제
            try
            {
                list.Items.RemoveAt(list.SelectedIndices[0]);
            }
            catch { }

            sum();

        }

        private void all_Cancel_Click(object sender, EventArgs e)
        {
            //리스트 전체 삭제
            list.Items.Clear();
            textBox1.Text = null;                           //총금액, 받을금액 초기화
            textBox3.Text = null;
        }

        private void sum()
        {
            //총금액 계산

            int i = 0;
            sumValue = 0;
            while (true)
            {
                try
                {
                    sumValue += int.Parse(list.Items[i].SubItems[2].Text);
                    textBox1.Text = sumValue.ToString();
                    i++;
                }
                catch
                {
                    if (i == 0)                         //선택 취소시 리스트뷰에 항목이 하나도 없다면 총금액, 받을 금액 초기화
                    {
                        textBox1.Text = null;
                        textBox3.Text = null;
                    }
                    i = 0;
                    break;
                }
            }
            textBox3.Text = textBox1.Text;
        }

        private bool comparision(ListViewItem item)
        {
            int i = 0;
            int listValue;
            while (true)
            {
                try
                {
                    if (list.Items[i].SubItems[0].Text == item.SubItems[0].Text)        //상품명을 비교하여 같은 이름 찾음
                    {
                        listValue = int.Parse(list.Items[i].SubItems[1].Text);          //리스트에 있는 수량을 가져옴
                        listValue += int.Parse(item.SubItems[1].Text);                  //수량에 새로 추가될 항목의 수량을 더함(+1)
                        list.Items[i].SubItems[2].Text = (int.Parse(item.SubItems[2].Text) * listValue).ToString();//가격x수량
                        list.Items[i].SubItems[1].Text = listValue.ToString();          //변환된 수량을 다시 리스트에 넣음
                        return false;
                    }
                }
                catch
                {
                    break;                                                              //동일한 상품명이 없으면 반복을 멈춤

                }
                i++;
            }
            return true;
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e) // 결제 버튼
        {
            int check;
            string str;
            Form4 f4 = new Form4();
            Form3 f3 = new Form3();


            try
            {

                str = list.Items[0].SubItems[0].ToString();

                f3.sumValue3 = sumValue;
                f3.textBox1.Text = f3.sumValue3.ToString();
                foreach (ListViewItem item in list.Items)
                {
                    f3.list.Items.Add((ListViewItem)item.Clone());
                }
                f3.ShowDialog();

                check = f3.check;
                // check4 = f4.check4;

                if (check > 0)
                {
                    Receipt re = new Receipt();

                    foreach (ListViewItem item in list.Items)
                    {
                        re.list.Items.Add((ListViewItem)item.Clone());
                    }
                    re.sumValue15 = sumValue;
                    re.label15.Text = re.sumValue15.ToString();
                    re.label14_Datemethod();
                    re.ShowDialog();

                    saveThePML(check);
                    //리스트 전체 삭제
                    list.Items.Clear();
                    textBox1.Text = null;                           //총금액, 받을금액 초기화
                    textBox3.Text = null;

                }
            }
            catch
            {
                MessageBox.Show("메뉴를 선택해주세요.");
            }

        }
        void saveThePML(int check)
        {
            string payment;
            String[] temp;
            if (check == 1)
                payment = "현금 결제";
            else
                payment = "카드 결제";


            temp = new String[] { identi.ToString(), DateTime.UtcNow.ToString(), textBox3.Text, payment };
            ListViewItem tmpItem;

            tmpItem = new ListViewItem(temp);

            f6.listView1.Items.Add(tmpItem);

            identi++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f6.Show();
        }
    }
}