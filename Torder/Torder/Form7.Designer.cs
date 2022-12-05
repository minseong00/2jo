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
            this.admin_pn_daily = new System.Windows.Forms.Panel();
            this.admin_lb_daily = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_gb_amount = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.admin_gb_amount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_pn_daily
            // 
            this.admin_pn_daily.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_pn_daily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admin_pn_daily.Location = new System.Drawing.Point(-1, 44);
            this.admin_pn_daily.Name = "admin_pn_daily";
            this.admin_pn_daily.Size = new System.Drawing.Size(684, 176);
            this.admin_pn_daily.TabIndex = 33;
            // 
            // admin_lb_daily
            // 
            this.admin_lb_daily.AutoSize = true;
            this.admin_lb_daily.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_daily.Location = new System.Drawing.Point(25, 2);
            this.admin_lb_daily.Name = "admin_lb_daily";
            this.admin_lb_daily.Size = new System.Drawing.Size(134, 37);
            this.admin_lb_daily.TabIndex = 34;
            this.admin_lb_daily.Text = "일일 정산";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.admin_gb_amount);
            this.panel1.Location = new System.Drawing.Point(-1, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 46);
            this.panel1.TabIndex = 3;
            // 
            // admin_gb_amount
            // 
            this.admin_gb_amount.Controls.Add(this.label3);
            this.admin_gb_amount.Controls.Add(this.label4);
            this.admin_gb_amount.Location = new System.Drawing.Point(7, -1);
            this.admin_gb_amount.Margin = new System.Windows.Forms.Padding(0);
            this.admin_gb_amount.Name = "admin_gb_amount";
            this.admin_gb_amount.Padding = new System.Windows.Forms.Padding(0);
            this.admin_gb_amount.Size = new System.Drawing.Size(671, 42);
            this.admin_gb_amount.TabIndex = 35;
            this.admin_gb_amount.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label3.Location = new System.Drawing.Point(631, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "합계";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.admin_lb_daily);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.admin_pn_daily);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 263);
            this.panel2.TabIndex = 35;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 263);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자_일일 정산";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.admin_gb_amount.ResumeLayout(false);
            this.admin_gb_amount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel admin_pn_daily;
        private System.Windows.Forms.Label admin_lb_daily;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox admin_gb_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}