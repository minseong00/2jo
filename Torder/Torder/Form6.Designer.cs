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
            this.label1 = new System.Windows.Forms.Label();
            this.admin_lb_olist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_gb_amount = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.admin_gb_amount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "테이블 1";
            // 
            // admin_lb_olist
            // 
            this.admin_lb_olist.AutoSize = true;
            this.admin_lb_olist.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_olist.Location = new System.Drawing.Point(25, 2);
            this.admin_lb_olist.Name = "admin_lb_olist";
            this.admin_lb_olist.Size = new System.Drawing.Size(134, 37);
            this.admin_lb_olist.TabIndex = 35;
            this.admin_lb_olist.Text = "주문 내역";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-1, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 46);
            this.panel1.TabIndex = 37;
            // 
            // admin_gb_amount
            // 
            this.admin_gb_amount.Controls.Add(this.label3);
            this.admin_gb_amount.Controls.Add(this.label4);
            this.admin_gb_amount.Location = new System.Drawing.Point(11, 136);
            this.admin_gb_amount.Margin = new System.Windows.Forms.Padding(0);
            this.admin_gb_amount.Name = "admin_gb_amount";
            this.admin_gb_amount.Padding = new System.Windows.Forms.Padding(0);
            this.admin_gb_amount.Size = new System.Drawing.Size(671, 42);
            this.admin_gb_amount.TabIndex = 6;
            this.admin_gb_amount.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
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
            this.label4.BackColor = System.Drawing.Color.Silver;
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
            this.panel2.Controls.Add(this.admin_gb_amount);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.admin_lb_olist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 263);
            this.panel2.TabIndex = 38;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 45);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(685, 173);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 263);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자_주문내역";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.admin_gb_amount.ResumeLayout(false);
            this.admin_gb_amount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label admin_lb_olist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox admin_gb_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}