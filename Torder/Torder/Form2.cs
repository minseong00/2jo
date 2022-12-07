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
        Panel[] panel1 = new Panel[8];
        Label[] label1 = new Label[8];
        Label[] label2 = new Label[8];
        Button[] button1 = new Button[8];
        Button[] button2 = new Button[8];
        Button[] button3 = new Button[8];

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
                label1[i] = new Label();
                label2[i] = new Label();
                panel1[i] = new Panel();
                button1[i] = new Button();
                button2[i] = new Button();
                button3[i] = new Button();
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

            panel1[p_index].Name = String.Format("pLine_{0}", p_index);
            panel1[p_index].Size = new Size(257, 1);
            panel1[p_index].BorderStyle = BorderStyle.FixedSingle;
            panel1[p_index].Location = new Point(0, 72);

            label1[p_index].Text = name;
            label1[p_index].Name = String.Format("lblName_{0}", p_index);
            label1[p_index].Font = new Font("맑은 고딕", 15);
            label1[p_index].AutoSize = true;
            label1[p_index].Location = new Point(11, 11);

            label2[p_index].Text = "1";
            label2[p_index].Name = String.Format("lblNum_{0}", p_index);
            label2[p_index].Font = new Font("맑은 고딕", 9);
            label2[p_index].AutoSize = true;
            label2[p_index].Location = new Point(206, 50);

            button1[p_index].Name = String.Format("btnD_{0}", p_index);
            button1[p_index].Text = "삭제";
            button1[p_index].Font = new Font("맑은 고딕", 9);
            button1[p_index].Size = new Size(61, 28);
            button1[p_index].Location = new Point(195, 3);
            button1[p_index].Click += new System.EventHandler(btnD_Click);

            button2[p_index].Name = String.Format("btnM_{0}", p_index);
            button2[p_index].Text = "-";
            button2[p_index].Font = new Font("맑은 고딕", 9);
            button2[p_index].Size = new Size(27, 23);
            button2[p_index].Location = new Point(167, 44);
            button2[p_index].Enabled = false;
            button2[p_index].Click += new System.EventHandler(btnM_Click);

            button3[p_index].Name = String.Format("btnP_{0}", p_index);
            button3[p_index].Text = "+";
            button3[p_index].Font = new Font("맑은 고딕", 9);
            button3[p_index].Size = new Size(27, 23);
            button3[p_index].Location = new Point(230, 44);
            button3[p_index].Click += new System.EventHandler(btnP_Click);

            this.panel_cart.Controls.Add(panel[p_index]);
            panel[p_index].Controls.Add(panel1[p_index]);
            panel[p_index].Controls.Add(label1[p_index]);
            panel[p_index].Controls.Add(label2[p_index]);
            panel[p_index].Controls.Add(button1[p_index]);
            panel[p_index].Controls.Add(button2[p_index]);
            panel[p_index].Controls.Add(button3[p_index]);
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
                    label1[panel_index].Text = panel[panel_index].Name.ToString();
                    panel_index++;
                }
            }

            for(; panel_index < panel.Length; panel_index++)
            {
                panel[panel_index] = new Panel();
                panel[panel_index].Name = "null";
                button1[panel_index].Click -= new System.EventHandler(btnD_Click);
                button2[panel_index].Click -= new System.EventHandler(btnM_Click);
                button3[panel_index].Click -= new System.EventHandler(btnP_Click);
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
                            label2[i].Text = (int.Parse(label2[i].Text.ToString()) - 1).ToString(); //라벨 배열 데이터 수정
                            con.Text = label2[i].Text; // 라벨 배열데이터를 라벨 컨트롤에 입력
                        }
                        
                        if (con.Name == String.Format("btnM_{0}", i)) // 패널 중에 일치하는 버튼 찾기
                        {
                            if (int.Parse(label2[i].Text) <= 1) // 라벨의 값이 1로 떨어질 경우 Minus 버튼 비활성화
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
                            label2[i].Text = (int.Parse(label2[i].Text.ToString()) + 1).ToString(); //라벨 배열 데이터 수정
                            con.Text = label2[i].Text; // 라벨 배열데이터를 라벨 컨트롤에 입력
                        }

                        if (con.Name == String.Format("btnM_{0}", i)) // 패널 중에 일치하는 버튼 찾기
                        {
                            if (int.Parse(label2[i].Text) > 1) // 라벨의 값이 2 이상일 경우 Minus 버튼 활성화
                                con.Enabled = true;
                        }
                    }

                }
            }
        }
        
    }
}
