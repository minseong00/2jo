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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

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

            //1.음식 패널을 클릭 시 해당 패널의 Name과 일치하는  음식 이름과 금액을 가져와 변수에 저장한다.
            fName.Add(String.Format("test_{0}", foodSelect));
            fPrice.Add(12310);
            fId.Add(foodAdd.Name.ToString());

            for (int i = 0; i < fName.Count; i++)
            {
                if (foodAdd.Name.ToString() == fName[i])
                    return;
            }

            
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

            for (int i = 0; i < fName.Count; i++)
            {
                if(delete.Parent.Name.ToString() == cPanel[i].Name.ToString())
                {
                    pCart_list.Controls.Remove(cPanel[i]);
                    fName.RemoveAt(i);
                    fPrice.RemoveAt(i);
                    clblNum[i].Text = "1";
                }
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {

        }

        private void btnP_Click(object sender, EventArgs e)
        {

        }

        private void pCart_order_Click(object sender, EventArgs e)
        {

        }
    }
}
