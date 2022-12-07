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
        List<Panel> panel = new List<Panel>(); // 주문 내역 각각의 패널
        List<Panel> pLine = new List<Panel>(); // 주문 사이 패널 줄
        List<Label> lblFName = new List<Label>(); // 음식명
        List<Label> lblFNum = new List<Label>(); // 음식 개수
        List<Label> lblFSum = new List<Label>(); // 음식 총 가격

        private void Form3_Load(object sender, EventArgs e)
        {
            // 창꺼짐 타이머 시작
            time_close.Start();
            dutNum = int.Parse(this.lblNum.Text);
            // access에서 테이블의 주문목록 가져와서 lvView에 넣기
            // DB 연결 및 주문내역 조회
            /* var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("SELECT [prod_name], sum([order_count]), sum([order_total_price]) FROM [order], [product] WHERE [order_table] = 1 and [order_prod] = [prod_id] GROUP BY [prod_name]", Conn);
            var myRead = Comm.ExecuteReader();
            while(myRead.Read())
            {
                // 상품명, 수량, 주문일자, 총 가격
                //this.lv_bill.Items.Add(new ListViewItem(new string[] { myRead[0].ToString(), myRead[1].ToString(), myRead[2].ToString()}));
                price += Convert.ToInt32(myRead[2].ToString());
            }
            */
            this.lb_amount.Text = price + "원";
            this.lblDutCost.Text = price + "원";
            
            // 사이즈 조정
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);

            //DB에서 해당 테이블 주문 내역 COUNT를 가져오기 = orderCount
            int orderCount = 15;
            List<string> foodName = new List<string>(); // db에서 주문내역에 음식 이름 가져오기
            List<int> fNum = new List<int>(); //db에서 주문내역에 주문 개수 가져오기
            List<int> fSum = new List<int>(); //db에서 주문 내역에 총 가격 가져오기
            
            for(int i = 0; i < orderCount; i++)
            {
                foodName.Add(String.Format("테스트용{0}", i));
                fNum.Add(123);
                fSum.Add(123);
            }

            for(int i = 0; i < orderCount; i++)
            {
                panel.Add(new Panel());
                pLine.Add(new Panel());
                lblFName.Add(new Label());
                lblFNum.Add(new Label());
                lblFSum.Add(new Label());

                panel[i].Name = String.Format("pOrder{0}", i);
                panel[i].Size = new Size(425, 53);
                panel[i].Location = new Point(0, 53 * i);

                pLine[i].Name = String.Format("pLine_{0}", i);
                pLine[i].Size = new Size(420, 2);
                pLine[i].BorderStyle = BorderStyle.FixedSingle;
                pLine[i].Location = new Point(12, 50);

                lblFName[i].Name = String.Format("FName_{0}", i);
                lblFName[i].Text = foodName[i];
                lblFName[i].Font = new Font("맑은 고딕", 13, FontStyle.Bold);
                lblFName[i].Location = new Point(8, 16);

                lblFNum[i].Name = String.Format("FNum_{0}", i);
                lblFNum[i].Text = String.Format("{0}개", fNum[i]);
                lblFNum[i].Font = new Font("맑은 고딕", 9, FontStyle.Bold);
                lblFNum[i].Location = new Point(263, 21);

                lblFSum[i].Name = String.Format("FSum_{0}", i);
                lblFSum[i].Text = fSum[i].ToString();
                lblFSum[i].Font = new Font("맑은 고딕", 13, FontStyle.Bold);
                lblFSum[i].Location = new Point(366, 15);

                panel[i].Controls.Add(pLine[i]);
                panel[i].Controls.Add(lblFName[i]);
                panel[i].Controls.Add(lblFNum[i]);
                panel[i].Controls.Add(lblFSum[i]);
                pBill.Controls.Add(panel[i]);
            }
            
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
