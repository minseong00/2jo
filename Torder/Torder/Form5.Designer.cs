namespace Torder
{
    partial class Form5
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
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lv_olist = new System.Windows.Forms.ListView();
            this.gb_amount = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.time_close = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_amount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_close.Location = new System.Drawing.Point(699, 14);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(86, 46);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문 내역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.label2.Location = new System.Drawing.Point(179, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "*마지막 주문건만 표시됩니다.";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblTimer.Location = new System.Drawing.Point(530, 38);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(163, 23);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "30초 후에 닫힙니다.";
            // 
            // lv_olist
            // 
            this.lv_olist.HideSelection = false;
            this.lv_olist.Location = new System.Drawing.Point(15, 78);
            this.lv_olist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_olist.Name = "lv_olist";
            this.lv_olist.Size = new System.Drawing.Size(773, 304);
            this.lv_olist.TabIndex = 4;
            this.lv_olist.UseCompatibleStateImageBehavior = false;
            // 
            // gb_amount
            // 
            this.gb_amount.Controls.Add(this.label3);
            this.gb_amount.Controls.Add(this.label4);
            this.gb_amount.Location = new System.Drawing.Point(15, 385);
            this.gb_amount.Margin = new System.Windows.Forms.Padding(0);
            this.gb_amount.Name = "gb_amount";
            this.gb_amount.Padding = new System.Windows.Forms.Padding(0);
            this.gb_amount.Size = new System.Drawing.Size(773, 52);
            this.gb_amount.TabIndex = 5;
            this.gb_amount.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label3.Location = new System.Drawing.Point(721, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label4.Location = new System.Drawing.Point(7, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "합계";
            // 
            // time_close
            // 
            this.time_close.Interval = 1000;
            this.time_close.Tick += new System.EventHandler(this.time_close_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 77);
            this.panel1.TabIndex = 6;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_amount);
            this.Controls.Add(this.lv_olist);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주문내역";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.gb_amount.ResumeLayout(false);
            this.gb_amount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ListView lv_olist;
        private System.Windows.Forms.GroupBox gb_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer time_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}