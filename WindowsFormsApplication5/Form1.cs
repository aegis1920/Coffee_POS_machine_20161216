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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form1 form1 = new Form1();
                this.Close();
                Form2 form2 = new Form2();
                form2.Show();
            }

            else
            {
                MessageBox.Show("아이디와 비밀번호가 올바르지 않습니다.", "주의", MessageBoxButtons.OK, (MessageBoxIcon)48);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
