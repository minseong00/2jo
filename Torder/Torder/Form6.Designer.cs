namespace Torder
{
    partial class Form6
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
            this.lbl_tName = new System.Windows.Forms.Label();
            this.admin_lb_olist = new System.Windows.Forms.Label();
            this.back_panel = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pLine = new System.Windows.Forms.Panel();
            this.pBottom = new System.Windows.Forms.Panel();
            this.order_sum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.back_panel.SuspendLayout();
            this.pMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tName
            // 
            this.lbl_tName.AutoSize = true;
            this.lbl_tName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_tName.Location = new System.Drawing.Point(165, 23);
            this.lbl_tName.Name = "lbl_tName";
            this.lbl_tName.Size = new System.Drawing.Size(56, 12);
            this.lbl_tName.TabIndex = 0;
            this.lbl_tName.Text = "테이블 1";
            // 
            // admin_lb_olist
            // 
            this.admin_lb_olist.AutoSize = true;
            this.admin_lb_olist.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_olist.Location = new System.Drawing.Point(25, 2);
            this.admin_lb_olist.Name = "admin_lb_olist";
            this.admin_lb_olist.Size = new System.Drawing.Size(134, 37);
            this.admin_lb_olist.TabIndex = 35;
            this.admin_lb_olist.Text = "주문 내역";
            // 
            // back_panel
            // 
            this.back_panel.BackColor = System.Drawing.Color.White;
            this.back_panel.Controls.Add(this.pMain);
            this.back_panel.Controls.Add(this.pLine);
            this.back_panel.Controls.Add(this.pBottom);
            this.back_panel.Controls.Add(this.lbl_tName);
            this.back_panel.Controls.Add(this.admin_lb_olist);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Location = new System.Drawing.Point(0, 0);
            this.back_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(700, 303);
            this.back_panel.TabIndex = 38;
            // 
            // pMain
            // 
            this.pMain.AutoScroll = true;
            this.pMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pMain.Controls.Add(this.panel4);
            this.pMain.Controls.Add(this.panel3);
            this.pMain.Location = new System.Drawing.Point(-1, 46);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(732, 211);
            this.pMain.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 50);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 50);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(544, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "38,900원";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "두루치기";
            // 
            // pLine
            // 
            this.pLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLine.Location = new System.Drawing.Point(5, 42);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(647, 2);
            this.pLine.TabIndex = 37;
            // 
            // pBottom
            // 
            this.pBottom.BackColor = System.Drawing.Color.Black;
            this.pBottom.Controls.Add(this.order_sum);
            this.pBottom.Controls.Add(this.label4);
            this.pBottom.Location = new System.Drawing.Point(0, 258);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(700, 45);
            this.pBottom.TabIndex = 36;
            // 
            // order_sum
            // 
            this.order_sum.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_sum.ForeColor = System.Drawing.Color.White;
            this.order_sum.Location = new System.Drawing.Point(327, 8);
            this.order_sum.Name = "order_sum";
            this.order_sum.Size = new System.Drawing.Size(354, 28);
            this.order_sum.TabIndex = 6;
            this.order_sum.Text = "0원";
            this.order_sum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(260, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "12:25:11";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(419, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "7개";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(6, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "1";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 303);
            this.ControlBox = false;
            this.Controls.Add(this.back_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자_주문내역";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.back_panel.ResumeLayout(false);
            this.back_panel.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.pBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label admin_lb_olist;
        public System.Windows.Forms.Label lbl_tName;
        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pLine;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label order_sum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
    }
}