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
        Label[] label2 = new Label[8];
        int panelY = 0;
        string[] panel_name = new string[8];

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
                label2[i] = new Label();
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
            int panelLCount = 0;
            panel_cart.AutoScrollPosition = new Point(0, 0);
            for (int i = 0; i < panel.Length; i++)
            {
                if (panel[i].Name == "")
                {
                    panelLCount = i;
                    break;
                }
            }
            panel[panelLCount].Name = String.Format("{0}", name);
            panel[panelLCount].Size = new Size(259, 73);
            panel[panelLCount].Location = new Point(0, 73 * panelY); // 0 73 146 219 
            panel_name[panelLCount] = panel[panelLCount].Name;
            panelY++;

            Panel panel1 = new Panel();
            panel1.Name = String.Format("panel_line{0}", panelLCount);
            panel1.Size = new Size(257, 1);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 72);

            Label label1 = new Label();
            label1.Text = name;
            label1.Name = String.Format("label{0}", panelLCount);
            label1.Font = new Font("맑은 고딕", 15);
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);

            label2[panelLCount].Text = "1";
            label2[panelLCount].Name = String.Format("lblNum{0}", panelLCount);
            label2[panelLCount].Font = new Font("맑은 고딕", 9);
            label2[panelLCount].AutoSize = true;
            label2[panelLCount].Location = new Point(200, 50);

            Button button1 = new Button();
            button1.Name = "panel{0}_btnDelete";
            button1.Text = "삭제";
            button1.Font = new Font("맑은 고딕", 9);
            button1.Size = new Size(61, 28);
            button1.Location = new Point(195, 3);
            button1.Click += new System.EventHandler(btnDelete_Click);

            Button button2 = new Button();
            button2.Name = "panel{0}_btnM";
            button2.Text = "-";
            button2.Font = new Font("맑은 고딕", 9);
            button2.Size = new Size(27, 23);
            button2.Location = new Point(158, 44);
            button2.Click += new System.EventHandler(btnM_Click);

            Button button3 = new Button();
            button3.Name = "panel{0}_btnP";
            button3.Text = "+";
            button3.Font = new Font("맑은 고딕", 9);
            button3.Size = new Size(27, 23);
            button3.Location = new Point(221, 44);
            button3.Click += new System.EventHandler(btnP_Click);

            this.panel_cart.Controls.Add(panel[panelLCount]);
            panel[panelLCount].Controls.Add(panel1);
            panel[panelLCount].Controls.Add(label1);
            panel[panelLCount].Controls.Add(label2[panelLCount]);
            panel[panelLCount].Controls.Add(button1);
            panel[panelLCount].Controls.Add(button2);
            panel[panelLCount].Controls.Add(button3);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button delete = sender as Button;
            for(int i = 0; i < panel.Length; i++)
            {
                if(delete.Parent.Name.ToString() == panel[i].Name.ToString())
                {
                    panel_cart.Controls.Remove(panel[i]);
                    break;
                }
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            Button minus = sender as Button;
            for (int i = 0; i < panel.Length; i++)
            {
                if (minus.Parent.Name.ToString() == panel[i].Name.ToString())
                {
                    panel_cart.Controls.Remove(panel[i]);
                }
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Button plus = sender as Button;

        }
        
    }
}
