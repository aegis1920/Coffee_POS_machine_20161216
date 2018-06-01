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
    public partial class Form4 : Form {

        bool mc = false;
        int x, x1, y, y1;
        public int check4 = 0;


        Graphics gr;
        Pen pen = new Pen(Color.Black);

        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            pictureBox1.Update();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        mc = true;

        x = e.X;
        y = e.Y;
    }

         private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        mc = false;
    }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        if (mc == true)
        {
            x1 = e.X;
            y1 = e.Y;

            pen.Color = Color.Black;
            pen.Width = 3;


            gr.DrawLine(pen, x, y, x1, y1);
        }
        x = x1;
        y = y1;
       }
/*-------------------------------사인 보드 완료, 결제 버튼 시작-------------------------------------------*/
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 완료되었습니다.", "결제");
            check4 = 2;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 취소되었습니다.", "결제취소");
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
