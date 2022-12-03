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
            this.SuspendLayout();
            // 
            // admin_pn_daily
            // 
            this.admin_pn_daily.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_pn_daily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admin_pn_daily.Location = new System.Drawing.Point(-1, 103);
            this.admin_pn_daily.Name = "admin_pn_daily";
            this.admin_pn_daily.Size = new System.Drawing.Size(702, 212);
            this.admin_pn_daily.TabIndex = 33;
            // 
            // admin_lb_daily
            // 
            this.admin_lb_daily.AutoSize = true;
            this.admin_lb_daily.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_daily.Location = new System.Drawing.Point(33, 61);
            this.admin_lb_daily.Name = "admin_lb_daily";
            this.admin_lb_daily.Size = new System.Drawing.Size(134, 37);
            this.admin_lb_daily.TabIndex = 34;
            this.admin_lb_daily.Text = "일일 정산";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-1, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 46);
            this.panel1.TabIndex = 3;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admin_lb_daily);
            this.Controls.Add(this.admin_pn_daily);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자_일일 정산";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel admin_pn_daily;
        private System.Windows.Forms.Label admin_lb_daily;
        private System.Windows.Forms.Panel panel1;
    }
}