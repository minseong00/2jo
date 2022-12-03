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
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_orderlist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.admin_lb_amount = new System.Windows.Forms.Label();
            this.admin_lb_total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_olist = new System.Windows.Forms.Panel();
            this.admin_lb_olist = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.admin_btn_olist = new System.Windows.Forms.Button();
            this.admin_btn_daily = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_daily
            // 
            this.btn_daily.Location = new System.Drawing.Point(221, 12);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Size = new System.Drawing.Size(164, 46);
            this.btn_daily.TabIndex = 19;
            this.btn_daily.Text = "일일 정산";
            this.btn_daily.UseVisualStyleBackColor = true;
            // 
            // btn_orderlist
            // 
            this.btn_orderlist.Location = new System.Drawing.Point(40, 12);
            this.btn_orderlist.Name = "btn_orderlist";
            this.btn_orderlist.Size = new System.Drawing.Size(164, 46);
            this.btn_orderlist.TabIndex = 18;
            this.btn_orderlist.Text = "주문 내역보기";
            this.btn_orderlist.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.admin_lb_amount);
            this.groupBox1.Controls.Add(this.admin_lb_total);
            this.groupBox1.Location = new System.Drawing.Point(11, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 45);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // admin_lb_amount
            // 
            this.admin_lb_amount.AutoSize = true;
            this.admin_lb_amount.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_amount.Location = new System.Drawing.Point(629, 9);
            this.admin_lb_amount.Name = "admin_lb_amount";
            this.admin_lb_amount.Size = new System.Drawing.Size(34, 30);
            this.admin_lb_amount.TabIndex = 27;
            this.admin_lb_amount.Text = "원";
            // 
            // admin_lb_total
            // 
            this.admin_lb_total.AutoSize = true;
            this.admin_lb_total.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_total.Location = new System.Drawing.Point(24, 9);
            this.admin_lb_total.Name = "admin_lb_total";
            this.admin_lb_total.Size = new System.Drawing.Size(55, 30);
            this.admin_lb_total.TabIndex = 26;
            this.admin_lb_total.Text = "합계";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pn_olist
            // 
            this.pn_olist.BackColor = System.Drawing.Color.White;
            this.pn_olist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_olist.Location = new System.Drawing.Point(40, 108);
            this.pn_olist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_olist.Name = "pn_olist";
            this.pn_olist.Size = new System.Drawing.Size(624, 204);
            this.pn_olist.TabIndex = 32;
            // 
            // admin_lb_olist
            // 
            this.admin_lb_olist.AutoSize = true;
            this.admin_lb_olist.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_lb_olist.Location = new System.Drawing.Point(35, 64);
            this.admin_lb_olist.Name = "admin_lb_olist";
            this.admin_lb_olist.Size = new System.Drawing.Size(134, 37);
            this.admin_lb_olist.TabIndex = 35;
            this.admin_lb_olist.Text = "주문 내역";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.admin_btn_olist);
            this.panel2.Controls.Add(this.admin_btn_daily);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 58);
            this.panel2.TabIndex = 36;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btn_close.Location = new System.Drawing.Point(574, 10);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 35);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // admin_btn_olist
            // 
            this.admin_btn_olist.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.admin_btn_olist.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.admin_btn_olist.Location = new System.Drawing.Point(63, 8);
            this.admin_btn_olist.Name = "admin_btn_olist";
            this.admin_btn_olist.Size = new System.Drawing.Size(164, 46);
            this.admin_btn_olist.TabIndex = 0;
            this.admin_btn_olist.Text = "주문 내역보기";
            this.admin_btn_olist.UseVisualStyleBackColor = false;
            // 
            // admin_btn_daily
            // 
            this.admin_btn_daily.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.admin_btn_daily.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.admin_btn_daily.Location = new System.Drawing.Point(268, 6);
            this.admin_btn_daily.Margin = new System.Windows.Forms.Padding(0);
            this.admin_btn_daily.Name = "admin_btn_daily";
            this.admin_btn_daily.Size = new System.Drawing.Size(164, 46);
            this.admin_btn_daily.TabIndex = 1;
            this.admin_btn_daily.Text = "일일 정산";
            this.admin_btn_daily.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.admin_lb_olist);
            this.Controls.Add(this.pn_olist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_daily);
            this.Controls.Add(this.btn_orderlist);
            this.Name = "Form6";
            this.Text = "관리자_주문내역";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_orderlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label admin_lb_amount;
        private System.Windows.Forms.Label admin_lb_total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_olist;
        private System.Windows.Forms.Label admin_lb_olist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button admin_btn_olist;
        private System.Windows.Forms.Button admin_btn_daily;
    }
}