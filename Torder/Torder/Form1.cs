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
        private void btnBill_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnOlist_Click(object sender, EventArgs e)
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
    }
}
