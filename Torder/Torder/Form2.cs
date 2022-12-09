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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //리스트에 추가된 패널의 개수
        Panel[] panel = new Panel[8];
        Panel[] pLine = new Panel[8];
        Label[] lblName = new Label[8];
        Label[] lblNum = new Label[8];
        Button[] btnD = new Button[8];
        Button[] btnM = new Button[8];
        Button[] btnP = new Button[8];

        int panelY = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(716, 399);
            this.MaximumSize = new Size(716, 399);
            for(int i = 0; i < panel.Length; i++)
            {
                panel[i] = new Panel();
                panel[i].Name = "null";
                lblName[i] = new Label();
                lblNum[i] = new Label();
                pLine[i] = new Panel();
                btnD[i] = new Button();
                btnM[i] = new Button();
                btnP[i] = new Button();
            }
        }

        private void btnBOpener_Click(object sender, EventArgs e)
        {
            add_list(btnBOpener.Text);
            btnBOpener.Enabled = false;
        }

        private void btnWTissue_Click(object sender, EventArgs e)
        {
            add_list(btnWTissue.Text);
            btnWTissue.Enabled = false;
        }

        private void btnSpoon_Click(object sender, EventArgs e)
        {
            add_list(btnSpoon.Text);
            btnSpoon.Enabled = false;
        }

        private void btnChopsticks_Click(object sender, EventArgs e)
        {
            add_list(btnChopsticks.Text);
            btnChopsticks.Enabled = false;
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            add_list(btnWater.Text);
            btnWater.Enabled = false;
        }

        private void btnApron_Click(object sender, EventArgs e)
        {
            add_list(btnApron.Text);
            btnApron.Enabled = false;
        }

        private void btnDish_Click(object sender, EventArgs e)
        {
            add_list(btnDish.Text);
            btnDish.Enabled = false;
        }

        private void btnCup_Click(object sender, EventArgs e)
        {
            add_list(btnCup.Text);
            btnCup.Enabled = false;
        }

        private void add_list(string name)
        {
            panel_cart.AutoScrollPosition = new Point(0, 0);
            int p_index = 0;
            for (int i = 0; i < panel.Length; i++)
            {
                if (panel[i].Name == "null")
                {
                    p_index = i;
                    panelY = i;
                    break;
                }
            }
            panel[p_index].Name = String.Format("{0}", name);
            panel[p_index].Size = new Size(259, 73);
            panel[p_index].Location = new Point(0, 73 * panelY); // 0 73 146 219

            pLine[p_index].Name = String.Format("pLine_{0}", p_index);
            pLine[p_index].Size = new Size(257, 1);
            pLine[p_index].BorderStyle = BorderStyle.FixedSingle;
            pLine[p_index].Location = new Point(0, 72);

            lblName[p_index].Text = name;
            lblName[p_index].Name = String.Format("lblName_{0}", p_index);
            lblName[p_index].Font = new Font("맑은 고딕", 15);
            lblName[p_index].AutoSize = true;
            lblName[p_index].Location = new Point(11, 11);

            lblNum[p_index].Text = "1";
            lblNum[p_index].Name = String.Format("lblNum_{0}", p_index);
            lblNum[p_index].Font = new Font("맑은 고딕", 9);
            lblNum[p_index].AutoSize = true;
            lblNum[p_index].Location = new Point(206, 50);

            btnD[p_index].Name = String.Format("btnD_{0}", p_index);
            btnD[p_index].Text = "삭제";
            btnD[p_index].Font = new Font("맑은 고딕", 9);
            btnD[p_index].Size = new Size(61, 28);
            btnD[p_index].Location = new Point(195, 3);
            btnD[p_index].Click += new System.EventHandler(btnD_Click);

            btnM[p_index].Name = String.Format("btnM_{0}", p_index);
            btnM[p_index].Text = "-";
            btnM[p_index].Font = new Font("맑은 고딕", 9);
            btnM[p_index].Size = new Size(27, 23);
            btnM[p_index].Location = new Point(167, 44);
            btnM[p_index].Enabled = false;
            btnM[p_index].Click += new System.EventHandler(btnM_Click);

            btnP[p_index].Name = String.Format("btnP_{0}", p_index);
            btnP[p_index].Text = "+";
            btnP[p_index].Font = new Font("맑은 고딕", 9);
            btnP[p_index].Size = new Size(27, 23);
            btnP[p_index].Location = new Point(230, 44);
            btnP[p_index].Click += new System.EventHandler(btnP_Click);

            panel[p_index].Controls.Add(pLine[p_index]);
            panel[p_index].Controls.Add(lblName[p_index]);
            panel[p_index].Controls.Add(lblNum[p_index]);
            panel[p_index].Controls.Add(btnD[p_index]);
            panel[p_index].Controls.Add(btnM[p_index]);
            panel[p_index].Controls.Add(btnP[p_index]);
            this.panel_cart.Controls.Add(panel[p_index]);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Button delete = sender as Button;
            int panel_index = 0;

            for (int i = 0; i < panel.Length; i++)
            {
                if (delete.Parent.Name.ToString() == panel[i].Name.ToString())
                {
                    /*
                     * 패널 배열 당기기
                     * 컨트롤 패널 로케이션 당기기
                     */
                    panel_cart.Controls.Remove(panel[i]);
                    foreach(Control con in this.Controls)
                    {
                        if (con.Text == panel[i].Name.ToString())
                        {
                            con.Enabled = true;
                        }
                    }
                    break;
                }
            }
            
            foreach (Control con in panel_cart.Controls)
            {
                if(panel_index < panel_cart.Controls.Count)
                {
                    panel[panel_index].Name = con.Name;
                    panel[panel_index].Size = con.Size;
                    panel[panel_index].Location = new Point(0, 73 * panel_index); // 0 73 146 219 
                    lblName[panel_index].Text = panel[panel_index].Name.ToString();
                    panel_index++;
                }
            }

            for(; panel_index < panel.Length; panel_index++)
            {
                panel[panel_index] = new Panel();
                panel[panel_index].Name = "null";
                btnD[panel_index].Click -= new System.EventHandler(btnD_Click);
                btnM[panel_index].Click -= new System.EventHandler(btnM_Click);
                btnP[panel_index].Click -= new System.EventHandler(btnP_Click);
            }

            panel_cart.Controls.Clear();

            for (int i = 0; i < panel.Length; i++)
            {
                if(panel[i].Name != "null")
                {
                    panel_cart.Controls.Add(panel[i]);
                }
            }
            
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            Button minus = sender as Button;
            for (int i = 0; i < panel.Length; i++) 
            {
                if (minus.Parent.Name.ToString() == panel[i].Name.ToString()) //생성된 패널 중 일치하는 패널 찾기
                {
                    foreach(Control con in panel[i].Controls)
                    {
                        if(con.Name == String.Format("lblNum_{0}", i)) // 패널 중에 일치하는 라벨 찾기
                        {
                            lblNum[i].Text = (int.Parse(lblNum[i].Text) - 1).ToString(); //라벨 배열 데이터 수정
                            con.Text = lblNum[i].Text; // 라벨 배열데이터를 라벨 컨트롤에 입력
                        }
                        
                        if (con.Name == String.Format("btnM_{0}", i)) // 패널 중에 일치하는 버튼 찾기
                        {
                            if (int.Parse(lblNum[i].Text) <= 1) // 라벨의 값이 1로 떨어질 경우 Minus 버튼 비활성화
                                con.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Button plus = sender as Button;
            for (int i = 0; i < panel.Length; i++)
            {
                if (plus.Parent.Name.ToString() == panel[i].Name.ToString()) //생성된 패널 중 일치하는 패널 찾기
                {
                    foreach (Control con in panel[i].Controls)
                    {
                        if (con.Name == String.Format("lblNum_{0}", i)) // 패널 중에 일치하는 라벨 찾기
                        {
                            lblNum[i].Text = (int.Parse(lblNum[i].Text) + 1).ToString(); //라벨 배열 데이터 수정
                            con.Text = lblNum[i].Text; // 라벨 배열데이터를 라벨 컨트롤에 입력
                        }

                        if (con.Name == String.Format("btnM_{0}", i)) // 패널 중에 일치하는 버튼 찾기
                        {
                            if (int.Parse(lblNum[i].Text) > 1) // 라벨의 값이 2 이상일 경우 Minus 버튼 활성화
                                con.Enabled = true;
                        }
                    }

                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult yes = MessageBox.Show("이대로 주문하시겠습니까??", "요청하기", MessageBoxButtons.YesNo);
            if(yes == DialogResult.Yes)
            {
                if (panel_cart.Controls.Count > 0)
                {
                    DialogResult ok = MessageBox.Show("선택하신 항목을 요청하셨습니다.", "요청완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (ok == DialogResult.OK)
                        this.Close();
                }
                else
                {
                    MessageBox.Show("항목을 선택해주세요.", "요청오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            DialogResult yes = MessageBox.Show("직원을 호출하시겠습니까??", "직원호출", MessageBoxButtons.YesNo);
            if(yes == DialogResult.Yes)
            {
                DialogResult ok = MessageBox.Show("직원을 호출하셨습니다.", "요청완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (ok == DialogResult.OK)
                    this.Close();
            }
            
        }
    }
}
