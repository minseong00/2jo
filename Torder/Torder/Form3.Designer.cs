﻿namespace Torder
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
<<<<<<< HEAD
            this.gbSum = new System.Windows.Forms.GroupBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lblTextSum = new System.Windows.Forms.Label();
=======
            this.lv_bill = new System.Windows.Forms.ListView();
            this.gbSum = new System.Windows.Forms.GroupBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lblTextSum = new System.Windows.Forms.Label();
            this.gbDut = new System.Windows.Forms.GroupBox();
>>>>>>> parent of d69873a (디자인 수정 중)
            this.lblDutCost = new System.Windows.Forms.Label();
            this.lblDutNum = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTextDut = new System.Windows.Forms.Label();
            this.time_close = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbDut = new System.Windows.Forms.GroupBox();
            this.gbSum.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDut.SuspendLayout();
=======
            this.gbSum.SuspendLayout();
            this.gbDut.SuspendLayout();
            this.panel1.SuspendLayout();
>>>>>>> parent of d69873a (디자인 수정 중)
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("맑은 고딕", 20F);
<<<<<<< HEAD
            this.lblBill.Location = new System.Drawing.Point(16, 9);
=======
            this.lblBill.Location = new System.Drawing.Point(18, 11);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(122, 46);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "계산서";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("맑은 고딕", 10F);
<<<<<<< HEAD
            this.lblTimer.Location = new System.Drawing.Point(453, 27);
=======
            this.lblTimer.Location = new System.Drawing.Point(518, 34);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(163, 23);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "30초 후에 닫힙니다.";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 13F);
<<<<<<< HEAD
            this.btnClose.Location = new System.Drawing.Point(614, 12);
=======
            this.btnClose.Location = new System.Drawing.Point(702, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbSum
            // 
<<<<<<< HEAD
            this.gbSum.Controls.Add(this.lb_amount);
            this.gbSum.Controls.Add(this.lblTextSum);
            this.gbSum.Location = new System.Drawing.Point(23, 276);
            this.gbSum.Name = "gbSum";
            this.gbSum.Size = new System.Drawing.Size(442, 56);
            this.gbSum.TabIndex = 4;
            this.gbSum.TabStop = false;
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lb_amount.Location = new System.Drawing.Point(400, 27);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(19, 15);
            this.lb_amount.TabIndex = 1;
            this.lb_amount.Text = "원";
            // 
            // lblTextSum
            // 
            this.lblTextSum.AutoSize = true;
            this.lblTextSum.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblTextSum.Location = new System.Drawing.Point(15, 27);
            this.lblTextSum.Name = "lblTextSum";
            this.lblTextSum.Size = new System.Drawing.Size(31, 15);
            this.lblTextSum.TabIndex = 0;
            this.lblTextSum.Text = "합계";
=======
            this.lv_bill.HideSelection = false;
            this.lv_bill.Location = new System.Drawing.Point(26, 75);
            this.lv_bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_bill.Name = "lv_bill";
            this.lv_bill.Size = new System.Drawing.Size(505, 262);
            this.lv_bill.TabIndex = 3;
            this.lv_bill.UseCompatibleStateImageBehavior = false;
>>>>>>> parent of d69873a (디자인 수정 중)
            // 
            // gbSum
            // 
            this.gbSum.Controls.Add(this.lb_amount);
            this.gbSum.Controls.Add(this.lblTextSum);
            this.gbSum.Location = new System.Drawing.Point(26, 345);
            this.gbSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSum.Name = "gbSum";
            this.gbSum.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSum.Size = new System.Drawing.Size(505, 70);
            this.gbSum.TabIndex = 4;
            this.gbSum.TabStop = false;
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lb_amount.Location = new System.Drawing.Point(457, 34);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(24, 20);
            this.lb_amount.TabIndex = 1;
            this.lb_amount.Text = "원";
            // 
            // lblTextSum
            // 
            this.lblTextSum.AutoSize = true;
            this.lblTextSum.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblTextSum.Location = new System.Drawing.Point(17, 34);
            this.lblTextSum.Name = "lblTextSum";
            this.lblTextSum.Size = new System.Drawing.Size(39, 20);
            this.lblTextSum.TabIndex = 0;
            this.lblTextSum.Text = "합계";
            // 
            // gbDut
            // 
            this.gbDut.Controls.Add(this.lblDutCost);
            this.gbDut.Controls.Add(this.lblDutNum);
            this.gbDut.Controls.Add(this.btnPlus);
            this.gbDut.Controls.Add(this.btnMinus);
            this.gbDut.Controls.Add(this.lblNum);
            this.gbDut.Controls.Add(this.lblTextDut);
            this.gbDut.Location = new System.Drawing.Point(550, 69);
            this.gbDut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDut.Name = "gbDut";
            this.gbDut.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDut.Size = new System.Drawing.Size(229, 346);
            this.gbDut.TabIndex = 5;
            this.gbDut.TabStop = false;
            // 
            // lblDutCost
            // 
            this.lblDutCost.AutoSize = true;
            this.lblDutCost.Font = new System.Drawing.Font("맑은 고딕", 9F);
<<<<<<< HEAD
            this.lblDutCost.Location = new System.Drawing.Point(94, 221);
            this.lblDutCost.Name = "lblDutCost";
            this.lblDutCost.Size = new System.Drawing.Size(19, 15);
=======
            this.lblDutCost.Location = new System.Drawing.Point(107, 276);
            this.lblDutCost.Name = "lblDutCost";
            this.lblDutCost.Size = new System.Drawing.Size(24, 20);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.lblDutCost.TabIndex = 11;
            this.lblDutCost.Text = "원";
            this.lblDutCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDutNum
            // 
            this.lblDutNum.AutoSize = true;
            this.lblDutNum.Font = new System.Drawing.Font("맑은 고딕", 9F);
<<<<<<< HEAD
            this.lblDutNum.Location = new System.Drawing.Point(81, 175);
            this.lblDutNum.Name = "lblDutNum";
            this.lblDutNum.Size = new System.Drawing.Size(42, 15);
=======
            this.lblDutNum.Location = new System.Drawing.Point(93, 219);
            this.lblDutNum.Name = "lblDutNum";
            this.lblDutNum.Size = new System.Drawing.Size(52, 20);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.lblDutNum.TabIndex = 10;
            this.lblDutNum.Text = "1 인당";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
<<<<<<< HEAD
            this.btnPlus.Location = new System.Drawing.Point(147, 93);
=======
            this.btnPlus.Location = new System.Drawing.Point(168, 116);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(34, 29);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
<<<<<<< HEAD
            this.btnMinus.Location = new System.Drawing.Point(24, 93);
=======
            this.btnMinus.Location = new System.Drawing.Point(27, 116);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(34, 29);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("맑은 고딕", 9F);
<<<<<<< HEAD
            this.lblNum.Location = new System.Drawing.Point(94, 98);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(14, 15);
=======
            this.lblNum.Location = new System.Drawing.Point(107, 122);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(17, 20);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "1";
            // 
            // lblTextDut
            // 
            this.lblTextDut.AutoSize = true;
            this.lblTextDut.Font = new System.Drawing.Font("맑은 고딕", 9F);
<<<<<<< HEAD
            this.lblTextDut.Location = new System.Drawing.Point(71, 36);
            this.lblTextDut.Name = "lblTextDut";
            this.lblTextDut.Size = new System.Drawing.Size(55, 15);
=======
            this.lblTextDut.Location = new System.Drawing.Point(81, 45);
            this.lblTextDut.Name = "lblTextDut";
            this.lblTextDut.Size = new System.Drawing.Size(69, 20);
>>>>>>> parent of d69873a (디자인 수정 중)
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
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblBill);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 70);
            this.panel1.TabIndex = 6;
            // 
<<<<<<< HEAD
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 208);
            this.panel2.TabIndex = 7;
            // 
            // gbDut
            // 
            this.gbDut.Controls.Add(this.lblDutCost);
            this.gbDut.Controls.Add(this.lblDutNum);
            this.gbDut.Controls.Add(this.btnPlus);
            this.gbDut.Controls.Add(this.btnMinus);
            this.gbDut.Controls.Add(this.lblNum);
            this.gbDut.Controls.Add(this.lblTextDut);
            this.gbDut.Location = new System.Drawing.Point(481, 55);
            this.gbDut.Name = "gbDut";
            this.gbDut.Size = new System.Drawing.Size(200, 277);
            this.gbDut.TabIndex = 5;
            this.gbDut.TabStop = false;
            // 
=======
>>>>>>> parent of d69873a (디자인 수정 중)
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDut);
            this.Controls.Add(this.gbSum);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDut);
            this.Controls.Add(this.gbSum);
            this.Controls.Add(this.lv_bill);
>>>>>>> parent of d69873a (디자인 수정 중)
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계산서";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbSum.ResumeLayout(false);
            this.gbSum.PerformLayout();
<<<<<<< HEAD
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDut.ResumeLayout(false);
            this.gbDut.PerformLayout();
=======
            this.gbDut.ResumeLayout(false);
            this.gbDut.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
>>>>>>> parent of d69873a (디자인 수정 중)
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnClose;
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox gbSum;
=======
        private System.Windows.Forms.ListView lv_bill;
        private System.Windows.Forms.GroupBox gbSum;
        private System.Windows.Forms.GroupBox gbDut;
>>>>>>> parent of d69873a (디자인 수정 중)
        private System.Windows.Forms.Label lblDutCost;
        private System.Windows.Forms.Label lblDutNum;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblTextDut;
        private System.Windows.Forms.Label lblTextSum;
        private System.Windows.Forms.Timer time_close;
        private System.Windows.Forms.Label lb_amount;
<<<<<<< HEAD

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbDut;
=======
        private System.Windows.Forms.Panel panel1;
>>>>>>> parent of d69873a (디자인 수정 중)
    }
}