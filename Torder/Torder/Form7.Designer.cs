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
            this.admin_lb_daily = new System.Windows.Forms.Label();
            this.daily_sum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.back_panel = new System.Windows.Forms.Panel();
            this.pLine = new System.Windows.Forms.Panel();
            this.pBottom = new System.Windows.Forms.Panel();
            this.back_panel.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.AutoScroll = true;
            this.pMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pMain.Location = new System.Drawing.Point(-1, 46);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(737, 211);
            this.pMain.TabIndex = 33;
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
            this.back_panel.ResumeLayout(false);
            this.back_panel.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.pBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label admin_lb_daily;
        private System.Windows.Forms.Label daily_sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Panel pLine;
        private System.Windows.Forms.Panel pBottom;
    }
}