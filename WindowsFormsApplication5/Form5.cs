using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form5 : Form
    {
        bool mc = false;
        int x, x1, y, y1;

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

            this.Text = "서명란";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        Graphics gr;

        Pen pen = new Pen(Color.Black);

        public Form5()
        {
            InitializeComponent();
        }
    }
}
