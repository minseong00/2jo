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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0; Data Source=2jo.accdb;Mode=ReadWrite";
        

        List<Panel> panel = new List<Panel>(); // 테이블 각각의 패널
        List<Label> lblTName = new List<Label>(); // 테이블 명
        List<Label> lblTSum = new List<Label>(); // 테이블 정산 가격

        private void Form7_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);


            int i = 0;
            string tName;
            int tSum;
            int ATSum = 0;

            
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            string sql = "SELECT SUM([order_total_price]) FROM [order] WHERE [order_table] = " + i + 1;
            var Comm = new OleDbCommand(sql, Conn);
            var Reader = Comm.ExecuteReader();
            while(Reader.Read())
            {
                tName = String.Format("테이블 {0}", i+1);
                tSum = Convert.ToInt32(Reader[0].ToString());
                ATSum += tSum;
                

            //for (int j = 0; j < 6; j++) { // 이 라인만 위에 주석이랑 전환하면 댐

                panel.Add(new Panel());
                lblTName.Add(new Label());
                lblTSum.Add(new Label());

                panel[i].Name = String.Format("tPanel_{0}", i);
                panel[i].Size = new Size(700, 50);
                panel[i].Location = new Point(0, 50 * i);

                lblTName[i].Name = String.Format("tName_{0}", i);
                lblTName[i].Text = tName;
                lblTName[i].Font = new Font("맑은 고딕", 15, FontStyle.Bold);
                lblTName[i].AutoSize = true;
                lblTName[i].Location = new Point(9, 14);

                lblTSum[i].Name = String.Format("tSum_{0}", i);
                lblTSum[i].Text = String.Format("{0}원", tSum);
                lblTSum[i].Font = new Font("맑은 고딕", 15, FontStyle.Bold);
                lblTSum[i].AutoSize = false;
                lblTSum[i].Size = new Size(206, 32);
                lblTSum[i].Location = new Point(435, 10);
                lblTSum[i].TextAlign = ContentAlignment.MiddleRight;
                

                panel[i].Controls.Add(lblTName[i]);
                panel[i].Controls.Add(lblTSum[i]);
                pMain.Controls.Add(panel[i]);

                daily_sum.Text = String.Format("{0}원", ATSum);
                i++;
            }
        }

        
    }
}
