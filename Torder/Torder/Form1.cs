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

        List<Panel> cPanel = new List<Panel>();
        List<Label> clblName = new List<Label>();
        List<Label> clblNum = new List<Label>();
        List<Label> clblSum = new List<Label>();
        List<Button> cBDelete = new List<Button>();
        List<Button> cBMinus = new List<Button>();
        List<Button> cBPlus = new List<Button>();
        int foodSelect = 0;


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
            {

                cPanel.Add(new Panel());
                clblName.Add(new Label());
                clblNum.Add(new Label());
                clblSum.Add(new Label());
                cBDelete.Add(new Button());
                cBMinus.Add(new Button());
                cBPlus.Add(new Button());
                
                panel_cart.Visible = true;
            }
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
            panel_center.AutoScrollPosition = new Point(0, 0);
        }

        private void btn_top_menu1_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 0);
        }

        private void btn_top_menu2_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 580);
        }

        private void btn_top_menu3_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 1160);
        }

        private void btn_left_menu2_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 1740);
        }

        private void btn_left_menu3_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 2320);
        }

        private void btn_left_menu4_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 2900);
        }
        
        private void btn_food_click(object sender, EventArgs e)
        {

        }
    }
}
