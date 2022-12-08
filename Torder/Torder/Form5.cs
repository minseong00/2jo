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
    public partial class Form5 : Form
    {
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0; Data Source=2jo.accdb;Mode=ReadWrite";
        public Form5()
        {
            InitializeComponent();
        }
        int closeTime = 29;
        int total_order = 0;
        List<Panel> panel = new List<Panel>(); // 주문 내역 각각의 패널
        List<Panel> pLine = new List<Panel>(); // 주문 사이 패널 줄
        List<Label> lblFName = new List<Label>(); // 음식명
        List<Label> lblFNum = new List<Label>(); // 음식 개수
        List<Label> lblFDate = new List<Label>(); // 음식 주문 시간
        List<Label> lblLNum = new List<Label>(); // 리스트 no
        private void Form5_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);
            time_close.Start();

            List<string> foodName = new List<string>(); // db에서 주문내역에 음식 이름 가져오기
            List<int> fNum = new List<int>(); //db에서 주문내역에 주문 개수 가져오기
            List<string> fDate = new List<string>(); //db에서 주문 내역에 총 가격 가져오기
            int i = 0;

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("SELECT TOP 3 [prod_name], [order_count], [order_date] FROM [order], [product] WHERE [order_prod] = [prod_id] and [order_table] = 1 ORDER BY [order_date] DESC", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                // 상품명, 수량, 주문일자, 총 가격
                foodName.Add(myRead[0].ToString());
                fNum.Add(Convert.ToInt32(myRead[1].ToString()));
                fDate.Add(myRead[2].ToString());
                total_order += Convert.ToInt32(myRead[1].ToString());
                panel.Add(new Panel());
                pLine.Add(new Panel());
                lblFName.Add(new Label());
                lblFNum.Add(new Label());
                lblFDate.Add(new Label());
                lblLNum.Add(new Label());

                panel[i].Name = String.Format("pOrder{0}", i);
                panel[i].Size = new Size(684, 63);
                panel[i].Location = new Point(0, 63 * i);

                pLine[i].Name = String.Format("pLine_{0}", i);
                pLine[i].Size = new Size(684, 2);
                pLine[i].BorderStyle = BorderStyle.FixedSingle;
                pLine[i].Location = new Point(16, 60);

                lblFName[i].Name = String.Format("FName_{0}", i);
                lblFName[i].Text = foodName[i];
                lblFName[i].Font = new Font("맑은 고딕", 20, FontStyle.Bold);
                lblFName[i].TextAlign = ContentAlignment.MiddleRight;
                lblFName[i].AutoSize = true;
                lblFName[i].Location = new Point(350, 16);

                lblFNum[i].Name = String.Format("FNum_{0}", i);
                lblFNum[i].Text = String.Format("{0}개", fNum[i]);
                lblFNum[i].Font = new Font("맑은 고딕", 20, FontStyle.Bold);
                lblFNum[i].AutoSize = true;
                lblFNum[i].Location = new Point(610, 14);

                lblLNum[i].Name = String.Format("LNum_{0}", i);
                lblLNum[i].Text = String.Format("{0}", 3-i);
                lblLNum[i].Font = new Font("맑은 고딕", 20, FontStyle.Bold);
                lblLNum[i].AutoSize = true;
                lblLNum[i].Location = new Point(32, 15);

                lblFDate[i].Name = String.Format("fDate_{0}", i);
                lblFDate[i].Text = fDate[i].ToString();
                lblFDate[i].Font = new Font("맑은 고딕", 20, FontStyle.Bold);
                lblFDate[i].AutoSize = true;
                lblFDate[i].Location = new Point(125, 15);

                panel[i].Controls.Add(lblLNum[i]);
                panel[i].Controls.Add(pLine[i]);
                panel[i].Controls.Add(lblFName[i]);
                panel[i].Controls.Add(lblFNum[i]);
                panel[i].Controls.Add(lblFDate[i]);
                pn_olist.Controls.Add(panel[i]);

                i++;
            }
            lblLNum[0].ForeColor = Color.Red;
            lblFDate[0].ForeColor = Color.Red;
            lbl_onum.Text = String.Format($"{total_order} 개    ");
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
