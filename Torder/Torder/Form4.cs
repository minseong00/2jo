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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form7 form7 = new Form7();
        Form6 form6 = new Form6();
        private void Form4_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_btn_olist_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = true;
            this.pn_olist.Visible = false;
            this.pn_daily.Visible = false;
            this.admin_btn_daily.Checked = false;
            if (this.admin_btn_olist.Checked == false) this.admin_btn_olist.Checked = true;

        }

        private void admin_btn_daily_Click(object sender, EventArgs e)
        {
            
            form7.TopLevel = false;
            form7.Dock = System.Windows.Forms.DockStyle.Fill;
            form7.FormBorderStyle = FormBorderStyle.None;
            form7.Parent = this.pn_daily;
            form7.Activate();
            this.pn_daily.Controls.Add(form7);
            this.panel2.Visible = false;
            this.pn_olist.Visible = false;
            this.pn_daily.Visible = true;
            form7.Show();
            this.admin_btn_olist.Checked = false;
            if (this.admin_btn_daily.Checked == false) this.admin_btn_daily.Checked = true;
        }

        private void btn_admin_table_Click(object sender, EventArgs e)
        {
            form6.TopLevel = false;
            form6.Dock = System.Windows.Forms.DockStyle.Fill;
            form6.FormBorderStyle = FormBorderStyle.None;
            form6.Parent = this.pn_olist;
            form6.Activate();

            form6.lbl_tName.Text = "테이블 " + ((Control)sender).Tag.ToString();

            this.pn_olist.Controls.Add(form6);
            this.panel2.Visible = false;
            this.pn_olist.Visible = true;
            this.pn_daily.Visible = false;
            form6.Show();

        }
        
    }
}
