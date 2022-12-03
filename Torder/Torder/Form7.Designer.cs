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
            this.lb_totalcount = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_orderlist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_totalcount
            // 
            this.lb_totalcount.AutoSize = true;
            this.lb_totalcount.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_totalcount.Location = new System.Drawing.Point(719, 15);
            this.lb_totalcount.Name = "lb_totalcount";
            this.lb_totalcount.Size = new System.Drawing.Size(44, 37);
            this.lb_totalcount.TabIndex = 27;
            this.lb_totalcount.Text = "원";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_total.Location = new System.Drawing.Point(27, 15);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(71, 37);
            this.lb_total.TabIndex = 26;
            this.lb_total.Text = "합계";
            // 
            // btn_daily
            // 
            this.btn_daily.Location = new System.Drawing.Point(253, 15);
            this.btn_daily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Size = new System.Drawing.Size(187, 58);
            this.btn_daily.TabIndex = 24;
            this.btn_daily.Text = "일일 정산";
            this.btn_daily.UseVisualStyleBackColor = true;
            // 
            // btn_orderlist
            // 
            this.btn_orderlist.Location = new System.Drawing.Point(58, 15);
            this.btn_orderlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_orderlist.Name = "btn_orderlist";
            this.btn_orderlist.Size = new System.Drawing.Size(187, 58);
            this.btn_orderlist.TabIndex = 23;
            this.btn_orderlist.Text = "주문 내역보기";
            this.btn_orderlist.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_totalcount);
            this.groupBox1.Controls.Add(this.lb_total);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(765, 56);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 58);
            this.button1.TabIndex = 32;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(58, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 255);
            this.panel1.TabIndex = 33;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_daily);
            this.Controls.Add(this.btn_orderlist);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form7";
            this.Text = "관리자_일일 정산";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_totalcount;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_orderlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}