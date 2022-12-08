using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0; Data Source=2jo.accdb;Mode=ReadWrite";
        //데이터 저장 배열
        List<string> fName = new List<string>();
        List<string> fId = new List<string>();
        List<int> fPrice = new List<int>();

        List<Panel> cPanel = new List<Panel>();
        List<Label> clblName = new List<Label>();
        List<Label> clblNum = new List<Label>();
        List<Label> clblSum = new List<Label>();
        List<Button> cBDelete = new List<Button>();
        List<Button> cBMinus = new List<Button>();
        List<Button> cBPlus = new List<Button>();
        int foodSelect = 0;
        int foodSum = 0;
        int foodPrice = 0;


        private void btn_call_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void btn_bill_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btn_oList_Click(object sender, EventArgs e)
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
            {
                panel_cart.Visible = true;
                if(pCart_list.Controls.Count < 1)
                {
                    pCart_sum.Visible = false;
                    pCart_price.Visible = false;
                }
            }
            else
                panel_cart.Visible = false;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void btn_left_menu1_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 0);
        }

        private void btn_top_menu1_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 0);
        }

        private void btn_top_menu2_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 580);
        }

        private void btn_top_menu3_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 1160);
        }

        private void btn_left_menu2_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 1740);
        }

        private void btn_left_menu3_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 2320);
        }

        private void btn_left_menu4_Click(object sender, EventArgs e)
        {
            panel_center.AutoScrollPosition = new Point(0, 2900);
        }
        
        private void btn_food_click(object sender, EventArgs e)
        {
            Panel foodAdd = sender as Panel;


            fId.Add(foodAdd.Name.ToString());

            for (foodSelect = 0; foodSelect < fName.Count; foodSelect++)
            {
                if (foodAdd.Name.ToString() == fId[foodSelect])
                {
                    fId.RemoveAt(foodSelect);
                    return;
                }
            }
            //1.음식 패널을 클릭 시 해당 패널의 Name과 일치하는  음식 이름과 금액을 가져와 변수에 저장한다.
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            string sql = "SELECT [prod_name], [prod_price] FROM [product] WHERE [prod_id] = '" + foodAdd.Name + "'";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();
            myRead.Read();
            fName.Add(myRead[0].ToString());
            fPrice.Add(Convert.ToInt32(myRead[1].ToString()));
            myRead.Close();
            Conn.Close();
            pCart_list.AutoScrollPosition = new Point(0, 0);

                cPanel.Add(new Panel());
                clblName.Add(new Label());
                clblNum.Add(new Label());
                clblSum.Add(new Label());
                cBDelete.Add(new Button());
                cBMinus.Add(new Button());
                cBPlus.Add(new Button());

                cPanel[foodSelect].Name = String.Format("cPanel_{0}", foodSelect);
                cPanel[foodSelect].Size = new Size(223, 66);
                cPanel[foodSelect].Location = new Point(0, 66 * foodSelect);

                clblName[foodSelect].Name = String.Format("clblName_{0}", foodSelect);
                clblName[foodSelect].Text = String.Format("{0}", fName[foodSelect]);
                clblName[foodSelect].Font = new Font("맑은 고딕", 13, FontStyle.Bold);
                clblName[foodSelect].AutoSize = true;
                clblName[foodSelect].Location = new Point(-1, 1);

                clblNum[foodSelect].Name = String.Format("clblNum_{0}", foodSelect);
                clblNum[foodSelect].Text = "1";
                clblNum[foodSelect].Font = new Font("맑은 고딕", 10, FontStyle.Bold);
                clblNum[foodSelect].AutoSize = true;
                clblNum[foodSelect].Location = new Point(39, 39);

                clblSum[foodSelect].Name = String.Format("clblSum_{0}", foodSelect);
                clblSum[foodSelect].Text = String.Format("{0}", fPrice[foodSelect]);
                clblSum[foodSelect].Font = new Font("맑은 고딕", 15, FontStyle.Bold);
                clblSum[foodSelect].AutoSize = true;
                clblSum[foodSelect].Location = new Point(120, 32);

                cBDelete[foodSelect].Name = String.Format("cBDelete{0}", foodSelect);
                cBDelete[foodSelect].Text = "삭제";
                cBDelete[foodSelect].Font = new Font("맑은 고딕", 9);
                cBDelete[foodSelect].Size = new Size(49, 23);
                cBDelete[foodSelect].Location = new Point(174, 0);
                cBDelete[foodSelect].Click += new System.EventHandler(btnD_Click);

                cBMinus[foodSelect].Name = String.Format("cBMinus{0}", foodSelect);
                cBMinus[foodSelect].Text = "-";
                cBMinus[foodSelect].Font = new Font("맑은 고딕", 9);
                cBMinus[foodSelect].Size = new Size(25, 23);
                cBMinus[foodSelect].Location = new Point(10, 38);
                cBMinus[foodSelect].Click += new System.EventHandler(btnM_Click);

                cBPlus[foodSelect].Name = String.Format("cBPlus{0}", foodSelect);
                cBPlus[foodSelect].Text = "+";
                cBPlus[foodSelect].Font = new Font("맑은 고딕", 9);
                cBPlus[foodSelect].Size = new Size(25, 23);
                cBPlus[foodSelect].Location = new Point(61, 38);
                cBPlus[foodSelect].Click += new System.EventHandler(btnP_Click);


                cPanel[foodSelect].Controls.Add(clblName[foodSelect]);
                cPanel[foodSelect].Controls.Add(clblNum[foodSelect]);
                cPanel[foodSelect].Controls.Add(clblSum[foodSelect]);
                cPanel[foodSelect].Controls.Add(cBDelete[foodSelect]);
                cPanel[foodSelect].Controls.Add(cBMinus[foodSelect]);
                cPanel[foodSelect].Controls.Add(cBPlus[foodSelect]);
                pCart_list.Controls.Add(cPanel[foodSelect]);

                if (pCart_list.Controls.Count > 0)
                {
                    foodSum += int.Parse(clblNum[foodSelect].Text);
                    foodPrice += fPrice[foodSelect];
                    pCart_sum.Text = String.Format("{0}가지 {1}개", foodSelect + 1, foodSum);
                    pCart_price.Text = String.Format("{0}원", foodPrice);
                }
                foodSelect++;

            panel_cart.Visible = true;
        }

        /*
            --------------------------------------------------
            1. 장바구니 내부 삭제 버튼 클릭 시 해당 패널을 삭제 시킨다.
            2. 해당 패널 인덱스의 음식명, 주문 개수, 가격 배열도 초기화 시킨다.
            3. 위치 당기기
            --------------------------------------------------
         */
        private void btnD_Click(object sender, EventArgs e)
        {
            Button delete = sender as Button;
            for(int i = 0; i < fId.Count; i++)
            {
                if(delete.Parent.Name.ToString() == cPanel[i].Name.ToString())
                {
                    pCart_list.Controls.RemoveAt(i);
                    fId.RemoveAt(i);
                    fName.RemoveAt(i);
                    fPrice.RemoveAt(i);
                    cPanel.RemoveAt(i);
                    clblName.RemoveAt(i);
                    clblNum.RemoveAt(i);
                    clblSum.RemoveAt(i);
                    cBDelete.RemoveAt(i);
                    cBMinus.RemoveAt(i);
                    cBPlus.RemoveAt(i);
                    //cBDelete[i].Click -= new System.EventHandler(btnD_Click);
                    //cBMinus[i].Click -= new System.EventHandler(btnM_Click);
                    //cBPlus[i].Click -= new System.EventHandler(btnP_Click);
                }
            }
            pCart_list.Controls.Clear();
            for (foodSelect = 0; foodSelect < cPanel.Count; foodSelect++)
            {
                cPanel[foodSelect].Location = new Point(0, 66 * foodSelect);
                pCart_list.Controls.Add(cPanel[foodSelect]);
            }

            

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            Button minus = sender as Button;
            for (int i = 0; i < fId.Count; i++)
            {
                if (minus.Parent.Name.ToString() == cPanel[i].Name.ToString())
                {
                    foreach(Control con in cPanel[i].Controls)
                    {
                        if(con.Name == String.Format("clblNum_{0}", foodSelect))
                        {
                            clblNum[i].Text = (int.Parse(clblNum[i].Text) - 1).ToString();
                            con.Text = clblNum[i].Text;
                        }
                    }
                }
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Button plus = sender as Button;
            for (int i = 0; i < fId.Count; i++)
            {
                if (plus.Parent.Name.ToString() == cPanel[i].Name.ToString())
                {
                    foreach (Control con in cPanel[i].Controls)
                    {
                        if (con.Name == String.Format("clblNum_{0}", i))
                        {
                            clblNum[i].Text = (int.Parse(clblNum[i].Text) + 1).ToString();
                            con.Text = clblNum[i].Text;
                        }
                    }
                }
            }
        }

        private void pCart_order_Click(object sender, EventArgs e)
        {
            Button order = sender as Button;
            DialogResult yes = MessageBox.Show("이대로 주문하시겠습니까??", "메뉴 주문", MessageBoxButtons.YesNo);
            if(yes == DialogResult.Yes)
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                // 여기에서 db 반복문 입력
                for (int i = 0; i < fPrice.Count; i++)
                {
                    int cnt = Convert.ToInt32(this.clblNum[i].Text);
                    string sql = "INSERT INTO [order]([order_table], [order_prod], [order_count], [order_date], [order_total_price]) VALUES (";
                    sql += 1 + ",'" + fId[i] + "' ," + cnt + ", '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' , " + cnt * fPrice[i] + ")";
                    var Comm = new OleDbCommand(sql, Conn);
                    var result = Comm.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // 장바구니 초기화 후 닫기
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // --------------------------------------------------------

                pCart_list.Controls.Clear();
                fId.Clear();
                fName.Clear();
                fPrice.Clear();
                cPanel.Clear();
                clblName.Clear();
                clblNum.Clear();
                clblSum.Clear();
                cBDelete.Clear();
                cBMinus.Clear();
                cBPlus.Clear();
                foodSelect = 0;
                foodSum = 0;
                foodPrice = 0;
                pCart_sum.Text = String.Format("0가지 0개");
                pCart_price.Text = String.Format("0원");
                pCart_sum.Visible = false;
                pCart_price.Visible = false;

                DialogResult ok = MessageBox.Show("주문이 완료되었습니다.", "주문 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (ok == DialogResult.OK)
                    panel_cart.Visible = false;
            }

        }
    }
}
