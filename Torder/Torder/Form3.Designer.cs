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
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbSum = new System.Windows.Forms.GroupBox();
            this.lblTextSum = new System.Windows.Forms.Label();
            this.gbDut = new System.Windows.Forms.GroupBox();
            this.lblDutCost = new System.Windows.Forms.Label();
            this.lblDutNum = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTextDut = new System.Windows.Forms.Label();
            this.time_close = new System.Windows.Forms.Timer(this.components);
            this.gbSum.SuspendLayout();
            this.gbDut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(24, 18);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(52, 15);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "계산서";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(544, 18);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(143, 15);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "30초 후에 닫힙니다.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(693, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 75);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 262);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbSum
            // 
            this.gbSum.Controls.Add(this.lblTextSum);
            this.gbSum.Location = new System.Drawing.Point(26, 345);
            this.gbSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSum.Name = "gbSum";
            this.gbSum.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSum.Size = new System.Drawing.Size(505, 70);
            this.gbSum.TabIndex = 4;
            this.gbSum.TabStop = false;
            // 
            // lblTextSum
            // 
            this.lblTextSum.AutoSize = true;
            this.lblTextSum.Location = new System.Drawing.Point(17, 34);
            this.lblTextSum.Name = "lblTextSum";
            this.lblTextSum.Size = new System.Drawing.Size(37, 15);
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
            this.lblDutCost.Location = new System.Drawing.Point(107, 276);
            this.lblDutCost.Name = "lblDutCost";
            this.lblDutCost.Size = new System.Drawing.Size(22, 15);
            this.lblDutCost.TabIndex = 11;
            this.lblDutCost.Text = "원";
            this.lblDutCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDutNum
            // 
            this.lblDutNum.AutoSize = true;
            this.lblDutNum.Location = new System.Drawing.Point(93, 219);
            this.lblDutNum.Name = "lblDutNum";
            this.lblDutNum.Size = new System.Drawing.Size(50, 15);
            this.lblDutNum.TabIndex = 10;
            this.lblDutNum.Text = "1 인당";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(168, 116);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(34, 29);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(27, 116);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(34, 29);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(107, 122);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(15, 15);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "1";
            // 
            // lblTextDut
            // 
            this.lblTextDut.AutoSize = true;
            this.lblTextDut.Location = new System.Drawing.Point(81, 45);
            this.lblTextDut.Name = "lblTextDut";
            this.lblTextDut.Size = new System.Drawing.Size(67, 15);
            this.lblTextDut.TabIndex = 6;
            this.lblTextDut.Text = "더치페이";
            // 
            // time_close
            // 
            this.time_close.Interval = 1000;
            this.time_close.Tick += new System.EventHandler(this.time_close_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbDut);
            this.Controls.Add(this.gbSum);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblBill);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계산서";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.Label lblTextSum;
        private System.Windows.Forms.Timer time_close;
    }
}