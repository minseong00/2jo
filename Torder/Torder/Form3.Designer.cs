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
            this.lblBill = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbSum = new System.Windows.Forms.GroupBox();
            this.gbDut = new System.Windows.Forms.GroupBox();
            this.lblDutCost = new System.Windows.Forms.Label();
            this.lblDutNum = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTextDut = new System.Windows.Forms.Label();
            this.lblTextSum = new System.Windows.Forms.Label();
            this.lblSumCost = new System.Windows.Forms.Label();
            this.gbSum.SuspendLayout();
            this.gbDut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(21, 14);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(41, 12);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "계산서";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(479, 14);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(101, 12);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "초 후에 닫힙니다.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(606, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(442, 210);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbSum
            // 
            this.gbSum.Controls.Add(this.lblSumCost);
            this.gbSum.Controls.Add(this.lblTextSum);
            this.gbSum.Location = new System.Drawing.Point(23, 276);
            this.gbSum.Name = "gbSum";
            this.gbSum.Size = new System.Drawing.Size(442, 56);
            this.gbSum.TabIndex = 4;
            this.gbSum.TabStop = false;
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
            // lblDutCost
            // 
            this.lblDutCost.AutoSize = true;
            this.lblDutCost.Location = new System.Drawing.Point(94, 221);
            this.lblDutCost.Name = "lblDutCost";
            this.lblDutCost.Size = new System.Drawing.Size(17, 12);
            this.lblDutCost.TabIndex = 11;
            this.lblDutCost.Text = "원";
            this.lblDutCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDutNum
            // 
            this.lblDutNum.AutoSize = true;
            this.lblDutNum.Location = new System.Drawing.Point(81, 175);
            this.lblDutNum.Name = "lblDutNum";
            this.lblDutNum.Size = new System.Drawing.Size(39, 12);
            this.lblDutNum.TabIndex = 10;
            this.lblDutNum.Text = "1 인당";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(147, 93);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(24, 93);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 23);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(94, 98);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(11, 12);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "1";
            // 
            // lblTextDut
            // 
            this.lblTextDut.AutoSize = true;
            this.lblTextDut.Location = new System.Drawing.Point(71, 36);
            this.lblTextDut.Name = "lblTextDut";
            this.lblTextDut.Size = new System.Drawing.Size(53, 12);
            this.lblTextDut.TabIndex = 6;
            this.lblTextDut.Text = "더치페이";
            // 
            // lblTextSum
            // 
            this.lblTextSum.AutoSize = true;
            this.lblTextSum.Location = new System.Drawing.Point(15, 27);
            this.lblTextSum.Name = "lblTextSum";
            this.lblTextSum.Size = new System.Drawing.Size(29, 12);
            this.lblTextSum.TabIndex = 0;
            this.lblTextSum.Text = "합계";
            // 
            // lblSumCost
            // 
            this.lblSumCost.AutoSize = true;
            this.lblSumCost.Location = new System.Drawing.Point(396, 27);
            this.lblSumCost.Name = "lblSumCost";
            this.lblSumCost.Size = new System.Drawing.Size(17, 12);
            this.lblSumCost.TabIndex = 1;
            this.lblSumCost.Text = "원";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.gbDut);
            this.Controls.Add(this.gbSum);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblBill);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "계산서";
            this.gbSum.ResumeLayout(false);
            this.gbSum.PerformLayout();
            this.gbDut.ResumeLayout(false);
            this.gbDut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gbSum;
        private System.Windows.Forms.GroupBox gbDut;
        private System.Windows.Forms.Label lblDutCost;
        private System.Windows.Forms.Label lblDutNum;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblTextDut;
        private System.Windows.Forms.Label lblSumCost;
        private System.Windows.Forms.Label lblTextSum;
    }
}