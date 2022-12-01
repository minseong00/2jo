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
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_orderlist = new System.Windows.Forms.Button();
            this.lv_orderlist = new System.Windows.Forms.ListView();
            this.lv_ch_menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ch_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ch_cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_daily
            // 
            this.btn_daily.Location = new System.Drawing.Point(220, 12);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Size = new System.Drawing.Size(164, 46);
            this.btn_daily.TabIndex = 19;
            this.btn_daily.Text = "일일 정산";
            this.btn_daily.UseVisualStyleBackColor = true;
            // 
            // btn_orderlist
            // 
            this.btn_orderlist.Location = new System.Drawing.Point(50, 12);
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
            this.lv_orderlist.Location = new System.Drawing.Point(50, 64);
            this.lv_orderlist.Name = "lv_orderlist";
            this.lv_orderlist.Size = new System.Drawing.Size(668, 331);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(50, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 45);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(629, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "합계";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv_orderlist);
            this.Controls.Add(this.btn_daily);
            this.Controls.Add(this.btn_orderlist);
            this.Name = "Form7";
            this.Text = "주문내역";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_orderlist;
        private System.Windows.Forms.ListView lv_orderlist;
        private System.Windows.Forms.ColumnHeader lv_ch_menu;
        private System.Windows.Forms.ColumnHeader lv_ch_count;
        private System.Windows.Forms.ColumnHeader lv_ch_cash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}