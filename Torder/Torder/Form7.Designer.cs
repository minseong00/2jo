namespace Torder
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMain = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.admin_lb_daily = new System.Windows.Forms.Label();
            this.daily_sum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.back_panel = new System.Windows.Forms.Panel();
            this.pLine = new System.Windows.Forms.Panel();
            this.pBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.back_panel.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.panel4);
            this.pMain.Location = new System.Drawing.Point(-1, 46);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(733, 211);
            this.pMain.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(-1, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 50);
            this.panel4.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 18);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "38,900원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "테이블 2";
            // 
            // admin_lb_daily
            // 
            this.admin_lb_daily.AutoSize = true;
            this.admin_lb_daily.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_daily.Location = new System.Drawing.Point(25, 2);
            this.admin_lb_daily.Name = "admin_lb_daily";
            this.admin_lb_daily.Size = new System.Drawing.Size(134, 37);
            this.admin_lb_daily.TabIndex = 34;
            this.admin_lb_daily.Text = "일일 정산";
            // 
            // daily_sum
            // 
            this.daily_sum.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.daily_sum.ForeColor = System.Drawing.Color.White;
            this.daily_sum.Location = new System.Drawing.Point(327, 8);
            this.daily_sum.Name = "daily_sum";
            this.daily_sum.Size = new System.Drawing.Size(354, 28);
            this.daily_sum.TabIndex = 6;
            this.daily_sum.Text = "0원";
            this.daily_sum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "합계";
            // 
            // back_panel
            // 
            this.back_panel.BackColor = System.Drawing.Color.White;
            this.back_panel.Controls.Add(this.pLine);
            this.back_panel.Controls.Add(this.pBottom);
            this.back_panel.Controls.Add(this.admin_lb_daily);
            this.back_panel.Controls.Add(this.pMain);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Location = new System.Drawing.Point(0, 0);
            this.back_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(700, 303);
            this.back_panel.TabIndex = 35;
            // 
            // pLine
            // 
            this.pLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLine.Location = new System.Drawing.Point(5, 42);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(647, 2);
            this.pLine.TabIndex = 35;
            // 
            // pBottom
            // 
            this.pBottom.BackColor = System.Drawing.Color.Black;
            this.pBottom.Controls.Add(this.daily_sum);
            this.pBottom.Controls.Add(this.label4);
            this.pBottom.Location = new System.Drawing.Point(0, 258);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(700, 45);
            this.pBottom.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 50);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(403, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "38,900원";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(9, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "테이블 1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(611, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "주문 내역";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 303);
            this.ControlBox = false;
            this.Controls.Add(this.back_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자_일일 정산";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.pMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.back_panel.ResumeLayout(false);
            this.back_panel.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.pBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label admin_lb_daily;
        private System.Windows.Forms.Label daily_sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pLine;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}