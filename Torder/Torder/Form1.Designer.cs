namespace Torder
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOlist = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btn_left_menu1 = new System.Windows.Forms.Button();
            this.btn_left_menu2 = new System.Windows.Forms.Button();
            this.btn_left_menu3 = new System.Windows.Forms.Button();
            this.btn_left_menu4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_top_menu1 = new System.Windows.Forms.Button();
            this.btn_top_menu2 = new System.Windows.Forms.Button();
            this.btn_top_menu3 = new System.Windows.Forms.Button();
            this.btn_call = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlist
            // 
            this.btnOlist.Location = new System.Drawing.Point(303, 15);
            this.btnOlist.Name = "btnOlist";
            this.btnOlist.Size = new System.Drawing.Size(75, 29);
            this.btnOlist.TabIndex = 0;
            this.btnOlist.Text = "주문내역";
            this.btnOlist.UseVisualStyleBackColor = true;
            this.btnOlist.Click += new System.EventHandler(this.btnOlist_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(396, 15);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 29);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "계산서";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btn_left_menu1
            // 
            this.btn_left_menu1.Location = new System.Drawing.Point(9, 20);
            this.btn_left_menu1.Name = "btn_left_menu1";
            this.btn_left_menu1.Size = new System.Drawing.Size(92, 33);
            this.btn_left_menu1.TabIndex = 2;
            this.btn_left_menu1.Text = "메인 메뉴";
            this.btn_left_menu1.UseVisualStyleBackColor = true;
            // 
            // btn_left_menu2
            // 
            this.btn_left_menu2.Location = new System.Drawing.Point(9, 59);
            this.btn_left_menu2.Name = "btn_left_menu2";
            this.btn_left_menu2.Size = new System.Drawing.Size(92, 33);
            this.btn_left_menu2.TabIndex = 3;
            this.btn_left_menu2.Text = "음료";
            this.btn_left_menu2.UseVisualStyleBackColor = true;
            // 
            // btn_left_menu3
            // 
            this.btn_left_menu3.Location = new System.Drawing.Point(9, 97);
            this.btn_left_menu3.Name = "btn_left_menu3";
            this.btn_left_menu3.Size = new System.Drawing.Size(92, 33);
            this.btn_left_menu3.TabIndex = 4;
            this.btn_left_menu3.Text = "주류";
            this.btn_left_menu3.UseVisualStyleBackColor = true;
            // 
            // btn_left_menu4
            // 
            this.btn_left_menu4.Location = new System.Drawing.Point(9, 138);
            this.btn_left_menu4.Name = "btn_left_menu4";
            this.btn_left_menu4.Size = new System.Drawing.Size(92, 33);
            this.btn_left_menu4.TabIndex = 5;
            this.btn_left_menu4.Text = "추가메뉴";
            this.btn_left_menu4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_admin);
            this.groupBox1.Controls.Add(this.btn_top_menu1);
            this.groupBox1.Controls.Add(this.btn_top_menu2);
            this.groupBox1.Controls.Add(this.btn_top_menu3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 61);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(613, 12);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(75, 43);
            this.btn_admin.TabIndex = 12;
            this.btn_admin.Text = "관리자용";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // btn_top_menu1
            // 
            this.btn_top_menu1.Location = new System.Drawing.Point(112, 12);
            this.btn_top_menu1.Name = "btn_top_menu1";
            this.btn_top_menu1.Size = new System.Drawing.Size(75, 43);
            this.btn_top_menu1.TabIndex = 9;
            this.btn_top_menu1.Text = "튀김";
            this.btn_top_menu1.UseVisualStyleBackColor = true;
            // 
            // btn_top_menu2
            // 
            this.btn_top_menu2.Location = new System.Drawing.Point(208, 12);
            this.btn_top_menu2.Name = "btn_top_menu2";
            this.btn_top_menu2.Size = new System.Drawing.Size(75, 43);
            this.btn_top_menu2.TabIndex = 10;
            this.btn_top_menu2.Text = "탕";
            this.btn_top_menu2.UseVisualStyleBackColor = true;
            // 
            // btn_top_menu3
            // 
            this.btn_top_menu3.Location = new System.Drawing.Point(306, 12);
            this.btn_top_menu3.Name = "btn_top_menu3";
            this.btn_top_menu3.Size = new System.Drawing.Size(75, 43);
            this.btn_top_menu3.TabIndex = 11;
            this.btn_top_menu3.Text = "식사류";
            this.btn_top_menu3.UseVisualStyleBackColor = true;
            // 
            // btn_call
            // 
            this.btn_call.Location = new System.Drawing.Point(9, 260);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(92, 33);
            this.btn_call.TabIndex = 13;
            this.btn_call.Text = "직원 호출";
            this.btn_call.UseVisualStyleBackColor = true;
            this.btn_call.Click += new System.EventHandler(this.btn_call_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_call);
            this.groupBox2.Controls.Add(this.btn_left_menu1);
            this.groupBox2.Controls.Add(this.btn_left_menu2);
            this.groupBox2.Controls.Add(this.btn_left_menu4);
            this.groupBox2.Controls.Add(this.btn_left_menu3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 299);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cart);
            this.groupBox3.Controls.Add(this.btnOlist);
            this.groupBox3.Controls.Add(this.btnBill);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(112, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btn_cart
            // 
            this.btn_cart.Location = new System.Drawing.Point(490, 15);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(75, 29);
            this.btn_cart.TabIndex = 14;
            this.btn_cart.Text = "장바구니";
            this.btn_cart.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(508, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 237);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(349, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 237);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 237);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "메인";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlist;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btn_left_menu1;
        private System.Windows.Forms.Button btn_left_menu2;
        private System.Windows.Forms.Button btn_left_menu3;
        private System.Windows.Forms.Button btn_left_menu4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_call;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_top_menu1;
        private System.Windows.Forms.Button btn_top_menu2;
        private System.Windows.Forms.Button btn_top_menu3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

