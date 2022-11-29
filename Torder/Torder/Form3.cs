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
        private void Form3_Load(object sender, EventArgs e)
        {
            // access에서 테이블의 주문목록 가져와서 lvView에 넣기
            time_close.Start();

        }

        private void time_close_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = String.Format("{0}", closeTime--) + "초 후에 사라집니다.";
            if (closeTime == 0) this.Close();
        }
    }
}
