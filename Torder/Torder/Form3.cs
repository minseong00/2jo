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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int closeTime = 29;
        int dutNum = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);
            // access에서 테이블의 주문목록 가져와서 lvView에 넣기
            time_close.Start();
            dutNum = int.Parse(this.lblNum.Text);
        }

        private void time_close_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = String.Format("{0}", closeTime--) + "초 후에 닫힙니다.";
            if (closeTime == 0) this.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (dutNum > 1)
            {
                dutNum--;
                this.lblNum.Text = dutNum.ToString();
                this.lblDutNum.Text = dutNum.ToString() + "인당";
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (dutNum < 99)
            {
                dutNum++;
                this.lblNum.Text = dutNum.ToString();
                this.lblDutNum.Text = dutNum.ToString() + "인당";
            }
        }
    }
}
