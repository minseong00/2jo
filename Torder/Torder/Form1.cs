using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_call_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void btn_bill_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btn_oList_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cart_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_cart.Checked == true)
                panel_cart.Visible = true;
            else
                panel_cart.Visible = false;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void btn_left_menu1_Click(object sender, EventArgs e)
        {
            Point btn_location = new Point(0, 0);
            panel_center.AutoScrollPosition = btn_location;
        }

        private void btn_top_menu1_Click(object sender, EventArgs e)
        {
            Point btn_location = new Point(0, 0);
            panel_center.AutoScrollPosition = btn_location;
        }

        private void btn_top_menu2_Click(object sender, EventArgs e)
        {
            Point btn_location = new Point(0, 580);
            panel_center.AutoScrollPosition = btn_location;
        }

        private void btn_top_menu3_Click(object sender, EventArgs e)
        {
            Point btn_location = new Point(0, 1160);
            panel_center.AutoScrollPosition = btn_location;
        }

        private void btn_left_menu2_Click(object sender, EventArgs e)
        {
            Point btn_location = new Point(0, 1740);
            panel_center.AutoScrollPosition = btn_location;
        }

        private void btn_left_menu3_Click(object sender, EventArgs e)
        {
            Point btn_location = new Point(0, 2320);
            panel_center.AutoScrollPosition = btn_location;
        }

        private void btn_left_menu4_Click(object sender, EventArgs e)
        {
            Point btn_location = new Point(0, 2900);
            panel_center.AutoScrollPosition = btn_location;
        }
    }
}
