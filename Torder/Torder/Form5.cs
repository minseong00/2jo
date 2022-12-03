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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int closeTime = 29;

        private void Form5_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);
            time_close.Start();
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void time_close_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = String.Format("{0}", closeTime--) + "초 후에 닫힙니다.";
            if (closeTime == 0) this.Close();
        }
    }
}
