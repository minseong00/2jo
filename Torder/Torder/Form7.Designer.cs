﻿namespace Torder
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
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_orderlist = new System.Windows.Forms.Button();
            this.lv_orderlist = new System.Windows.Forms.ListView();
            this.lv_ch_menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ch_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ch_cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_totalcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_daily
            // 
            this.btn_daily.Location = new System.Drawing.Point(304, 12);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Size = new System.Drawing.Size(164, 46);
            this.btn_daily.TabIndex = 19;
            this.btn_daily.Text = "일일 정산";
            this.btn_daily.UseVisualStyleBackColor = true;
            // 
            // btn_orderlist
            // 
            this.btn_orderlist.Location = new System.Drawing.Point(106, 12);
            this.btn_orderlist.Name = "btn_orderlist";
            this.btn_orderlist.Size = new System.Drawing.Size(164, 46);
            this.btn_orderlist.TabIndex = 18;
            this.btn_orderlist.Text = "주문 내역보기";
            this.btn_orderlist.UseVisualStyleBackColor = true;
            // 
            // lv_orderlist
            // 
            this.lv_orderlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_ch_menu,
            this.lv_ch_count,
            this.lv_ch_cash});
            this.lv_orderlist.HideSelection = false;
            this.lv_orderlist.Location = new System.Drawing.Point(89, 96);
            this.lv_orderlist.Name = "lv_orderlist";
            this.lv_orderlist.Size = new System.Drawing.Size(604, 234);
            this.lv_orderlist.TabIndex = 20;
            this.lv_orderlist.UseCompatibleStateImageBehavior = false;
            this.lv_orderlist.View = System.Windows.Forms.View.Details;
            // 
            // lv_ch_menu
            // 
            this.lv_ch_menu.Text = "메뉴";
            this.lv_ch_menu.Width = 200;
            // 
            // lv_ch_count
            // 
            this.lv_ch_count.Text = "수량";
            // 
            // lv_ch_cash
            // 
            this.lv_ch_cash.Text = "금액";
            this.lv_ch_cash.Width = 100;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_total.Location = new System.Drawing.Point(101, 344);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(55, 30);
            this.lb_total.TabIndex = 21;
            this.lb_total.Text = "합계";
            // 
            // lb_totalcount
            // 
            this.lb_totalcount.AutoSize = true;
            this.lb_totalcount.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_totalcount.Location = new System.Drawing.Point(547, 344);
            this.lb_totalcount.Name = "lb_totalcount";
            this.lb_totalcount.Size = new System.Drawing.Size(34, 30);
            this.lb_totalcount.TabIndex = 22;
            this.lb_totalcount.Text = "원";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_totalcount);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lv_orderlist);
            this.Controls.Add(this.btn_daily);
            this.Controls.Add(this.btn_orderlist);
            this.Name = "Form7";
            this.Text = "주문내역";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_orderlist;
        private System.Windows.Forms.ListView lv_orderlist;
        private System.Windows.Forms.ColumnHeader lv_ch_menu;
        private System.Windows.Forms.ColumnHeader lv_ch_count;
        private System.Windows.Forms.ColumnHeader lv_ch_cash;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_totalcount;
    }
}