using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Torder
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0; Data Source=2jo.accdb;Mode=ReadWrite";

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int closeTime = 29;
        int dutNum = 0;
        int price = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            // 창꺼짐 타이머 시작
            time_close.Start();
            dutNum = int.Parse(this.lblNum.Text);
            // access에서 테이블의 주문목록 가져와서 lvView에 넣기
            // DB 연결 및 주문내역 조회
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("SELECT [order_prod], [order_count], [order_date], [order_total_price] FROM [order] WHERE [order_table] = 1", Conn);
            var myRead = Comm.ExecuteReader();
            while(myRead.Read())
            {
                // 상품명, 수량, 주문일자, 총 가격
                this.lv_bill.Items.Add(new ListViewItem(new string[] { myRead[0].ToString(), myRead[1].ToString(), myRead[2].ToString(), myRead[3].ToString() }));
                price += Convert.ToInt32(myRead[3].ToString());
            }
            this.lb_amount.Text = price + "원";
            this.lblDutCost.Text = price + "원";
            
            // 사이즈 조정
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);

            
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
                this.lblDutNum.Text = dutNum.ToString() + " 인당";
                this.lblDutCost.Text = price / dutNum + "원";
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (dutNum < 99)
            {
                dutNum++;
                this.lblNum.Text = dutNum.ToString();
                this.lblDutNum.Text = dutNum.ToString() + " 인당";
                this.lblDutCost.Text = price / dutNum + "원";
            }
        }
    }
}
