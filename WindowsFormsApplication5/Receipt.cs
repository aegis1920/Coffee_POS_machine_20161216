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
    public partial class Receipt : Form
    {
        public int sumValue15;

        public Receipt()
        {
            InitializeComponent();
        }

        public void label14_Datemethod()
        {
            label14.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
        }

        public void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Receipt_Load_1(object sender, EventArgs e)
        {

        }
    }
}
