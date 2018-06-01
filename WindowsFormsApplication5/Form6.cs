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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            //폼이 닫히는 것을 막고 보이지 않게만 함.
            e.Cancel = true;
            this.Visible = false;
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            int sum = 0;

            foreach (ListViewItem temp in listView1.Items)
                sum +=int.Parse(temp.SubItems[2].Text);
            label1.Text = "총 판매량 : " + listView1.Items.Count.ToString();
            label2.Text = "총 판매금액 : " + sum.ToString();
        }
    }
}
