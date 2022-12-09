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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0; Data Source=2jo.accdb;Mode=ReadWrite";

        List<Panel> panel = new List<Panel>(); // 주문 내역 각각의 패널
        List<Label> lblNum = new List<Label>(); // 주문 번호
        List<Label> lblName = new List<Label>(); // 음식명
        List<Label> lblDate = new List<Label>(); // 주문 일자
        List<Label> lblCount = new List<Label>(); // 음식 수량
        List<Label> lblPrice = new List<Label>(); // 음식 총 가격
        int orderCount = 0;

        private void Form6_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);

            int tableNum = int.Parse((lbl_tName.ToString()).Substring((lbl_tName.ToString().Length - 1)));

            int i = 0;
            string fName;
            string oDate;
            int fNum;
            int fPrice;
            int priceSum = 0;

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            string sql = "SELECT COUNT(*) FROM [order] WHERE [order_table] = " + tableNum;
            var Comm = new OleDbCommand(sql, Conn);
            var Reader = Comm.ExecuteReader();
            Reader.Read();
            orderCount = Convert.ToInt32(Reader[0].ToString());
            sql = "SELECT [prod_name], [order_date], [order_count], [order_total] FROM [order], [product] WHERE [order_table] = " + tableNum + " ORDER BY [order_date] DESC";
            Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();
            while(myRead.Read())
            {
                fName = myRead[0].ToString();
                oDate = myRead[1].ToString();
                fNum = Convert.ToInt32(myRead[2].ToString());
                fPrice = Convert.ToInt32(myRead[3].ToString());

                panel.Add(new Panel());
                lblNum.Add(new Label());
                lblName.Add(new Label());
                lblDate.Add(new Label());
                lblCount.Add(new Label());
                lblPrice.Add(new Label());

                panel[i].Name = String.Format("oList_{0}", i);
                panel[i].Size = new Size(701, 50);
                panel[i].Location = new Point(0, 50 * i);

                lblNum[i].Name = String.Format("oCount_{0}", i);
                lblNum[i].Text = String.Format("{0}", orderCount - i);
                lblNum[i].Font = new Font("맑은 고딕", 16, FontStyle.Bold);
                lblNum[i].Location = new Point(6, 8);

                lblName[i].Name = String.Format("oFName_{0}", i);
                lblName[i].Text = String.Format("{0}", fName);
                lblName[i].Font = new Font("맑은 고딕", 15, FontStyle.Bold);
                lblName[i].Location = new Point(62, 14);

                lblDate[i].Name = String.Format("oDate_{0}", i);
                lblDate[i].Text = String.Format("{0}", oDate);
                lblDate[i].Font = new Font("맑은 고딕", 12, FontStyle.Bold);
                lblDate[i].Location = new Point(260, 17);

                lblCount[i].Name = String.Format("oFCount_{0}", i);
                lblCount[i].Text = String.Format("{0}개", fNum);
                lblCount[i].Font = new Font("맑은 고딕", 12, FontStyle.Bold);
                lblCount[i].AutoSize = false;
                lblCount[i].Size = new Size(100, 23);
                lblCount[i].TextAlign = ContentAlignment.MiddleRight;
                lblCount[i].Location = new Point(419, 16);

                lblPrice[i].Name = String.Format("oPrice_{0}", i);
                lblPrice[i].Text = String.Format("{0}원", fPrice);
                lblPrice[i].Font = new Font("맑은 고딕", 15, FontStyle.Bold);
                lblPrice[i].AutoSize = false;
                lblPrice[i].Size = new Size(154, 32);
                lblPrice[i].TextAlign = ContentAlignment.MiddleRight;
                lblPrice[i].Location = new Point(544, 10);

                panel[i].Controls.Add(lblNum[i]);
                panel[i].Controls.Add(lblName[i]);
                panel[i].Controls.Add(lblDate[i]);
                panel[i].Controls.Add(lblCount[i]);
                panel[i].Controls.Add(lblPrice[i]);
                pMain.Controls.Add(panel[i]);

                i++;

                priceSum += fPrice;

            }

            order_sum.Text = String.Format("{0}원", priceSum);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
