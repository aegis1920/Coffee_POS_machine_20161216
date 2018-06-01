using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        int one;
        public int sumValue3;

        public int check = 0; //결제 확인용;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {
            int sub=0;
            if (textBox4.Text != "")
            {
                sub = int.Parse(textBox4.Text) - int.Parse(textBox1.Text);
                textBox2.Text = sub.ToString();
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text += "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Receipt re = new Receipt();
            if (textBox4.Text == "")
                MessageBox.Show("받은 금액을 입력해주세요.", "결제");
            else if (int.Parse(textBox2.Text) < 0)
                MessageBox.Show("결제 금액이 부족합니다.");
            else
            {
                if (MessageBox.Show("결제가 완료되었습니다") == DialogResult.OK)
                    check = 1;
 
                Close();
            }
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text;
            Form4 f4 = new Form4();
            Receipt re = new Receipt();

            f4.ShowDialog();

            /*if (MessageBox.Show("걸제가 완료되었습니다") == DialogResult.OK)
                //re.Show();*/
            check = f4.check4;

            //MessageBox.Show(f4.check4.ToString());
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox4.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox4.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Text += "00";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("결제를 취소하시겠습니까?", "결제 취소", MessageBoxButtons.YesNo)==DialogResult.Yes)
            Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
