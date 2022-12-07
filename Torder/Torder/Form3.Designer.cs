namespace Torder
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lv_bill = new System.Windows.Forms.ListView();
            this.lblDutCost = new System.Windows.Forms.Label();
            this.lblDutNum = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTextDut = new System.Windows.Forms.Label();
            this.time_close = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextSum = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.lblBill.ForeColor = System.Drawing.Color.White;
            this.lblBill.Location = new System.Drawing.Point(16, 9);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(98, 37);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "계산서";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(453, 27);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(136, 19);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "30초 후에 닫힙니다.";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(614, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lv_bill
            // 
            this.lv_bill.HideSelection = false;
            this.lv_bill.Location = new System.Drawing.Point(20, 74);
            this.lv_bill.Name = "lv_bill";
            this.lv_bill.Size = new System.Drawing.Size(442, 210);
            this.lv_bill.TabIndex = 3;
            this.lv_bill.UseCompatibleStateImageBehavior = false;
            // 
            // lblDutCost
            // 
            this.lblDutCost.AutoSize = true;
            this.lblDutCost.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDutCost.ForeColor = System.Drawing.Color.White;
            this.lblDutCost.Location = new System.Drawing.Point(91, 225);
            this.lblDutCost.Name = "lblDutCost";
            this.lblDutCost.Size = new System.Drawing.Size(46, 40);
            this.lblDutCost.TabIndex = 11;
            this.lblDutCost.Text = "원";
            this.lblDutCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDutNum
            // 
            this.lblDutNum.AutoSize = true;
            this.lblDutNum.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDutNum.ForeColor = System.Drawing.Color.White;
            this.lblDutNum.Location = new System.Drawing.Point(86, 169);
            this.lblDutNum.Name = "lblDutNum";
            this.lblDutNum.Size = new System.Drawing.Size(57, 21);
            this.lblDutNum.TabIndex = 10;
            this.lblDutNum.Text = "1 인당";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Location = new System.Drawing.Point(159, 106);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Location = new System.Drawing.Point(36, 106);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 23);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(99, 92);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(32, 37);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "1";
            // 
            // lblTextDut
            // 
            this.lblTextDut.AutoSize = true;
            this.lblTextDut.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTextDut.ForeColor = System.Drawing.Color.White;
            this.lblTextDut.Location = new System.Drawing.Point(41, 19);
            this.lblTextDut.Name = "lblTextDut";
            this.lblTextDut.Size = new System.Drawing.Size(148, 45);
            this.lblTextDut.TabIndex = 6;
            this.lblTextDut.Text = "더치페이";
            // 
            // time_close
            // 
            this.time_close.Interval = 1000;
            this.time_close.Tick += new System.EventHandler(this.time_close_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblBill);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 56);
            this.panel1.TabIndex = 6;
            // 
            // lblTextSum
            // 
            this.lblTextSum.AutoSize = true;
            this.lblTextSum.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lblTextSum.ForeColor = System.Drawing.Color.White;
            this.lblTextSum.Location = new System.Drawing.Point(15, 17);
            this.lblTextSum.Name = "lblTextSum";
            this.lblTextSum.Size = new System.Drawing.Size(52, 28);
            this.lblTextSum.TabIndex = 0;
            this.lblTextSum.Text = "합계";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lb_amount.ForeColor = System.Drawing.Color.White;
            this.lb_amount.Location = new System.Drawing.Point(430, 17);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(32, 28);
            this.lb_amount.TabIndex = 1;
            this.lb_amount.Text = "원";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lb_amount);
            this.panel2.Controls.Add(this.lblTextSum);
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 56);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblDutCost);
            this.panel3.Controls.Add(this.lblDutNum);
            this.panel3.Controls.Add(this.btnPlus);
            this.panel3.Controls.Add(this.btnMinus);
            this.panel3.Controls.Add(this.lblNum);
            this.panel3.Controls.Add(this.lblTextDut);
            this.panel3.Location = new System.Drawing.Point(480, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 306);
            this.panel3.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_bill);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계산서";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lv_bill;
        private System.Windows.Forms.Label lblDutCost;
        private System.Windows.Forms.Label lblDutNum;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblTextDut;
        private System.Windows.Forms.Timer time_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextSum;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}