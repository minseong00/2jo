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
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_top_menu1 = new System.Windows.Forms.Button();
            this.btn_top_menu2 = new System.Windows.Forms.Button();
            this.btn_top_menu3 = new System.Windows.Forms.Button();
            this.btn_call = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.CheckBox();
            this.panel_cart = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_left_menu3 = new System.Windows.Forms.Button();
            this.btn_left_menu2 = new System.Windows.Forms.Button();
            this.btn_left_menu4 = new System.Windows.Forms.Button();
            this.btn_left_menu1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlist
            // 
            this.btnOlist.Font = new System.Drawing.Font("굴림", 13F);
            this.btnOlist.Location = new System.Drawing.Point(474, 10);
            this.btnOlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOlist.Name = "btnOlist";
            this.btnOlist.Size = new System.Drawing.Size(108, 32);
            this.btnOlist.TabIndex = 0;
            this.btnOlist.Text = "주문내역";
            this.btnOlist.UseVisualStyleBackColor = true;
            this.btnOlist.Click += new System.EventHandler(this.btnOlist_Click);
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("굴림", 13F);
            this.btnBill.Location = new System.Drawing.Point(588, 10);
            this.btnBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(86, 32);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "계산서";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(702, 6);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(86, 54);
            this.btn_admin.TabIndex = 12;
            this.btn_admin.Text = "관리자용";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_top_menu1
            // 
            this.btn_top_menu1.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_top_menu1.Location = new System.Drawing.Point(320, 8);
            this.btn_top_menu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_top_menu1.Name = "btn_top_menu1";
            this.btn_top_menu1.Size = new System.Drawing.Size(86, 54);
            this.btn_top_menu1.TabIndex = 9;
            this.btn_top_menu1.Text = "튀김";
            this.btn_top_menu1.UseVisualStyleBackColor = true;
            // 
            // btn_top_menu2
            // 
            this.btn_top_menu2.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_top_menu2.Location = new System.Drawing.Point(136, 8);
            this.btn_top_menu2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_top_menu2.Name = "btn_top_menu2";
            this.btn_top_menu2.Size = new System.Drawing.Size(86, 54);
            this.btn_top_menu2.TabIndex = 10;
            this.btn_top_menu2.Text = "탕";
            this.btn_top_menu2.UseVisualStyleBackColor = true;
            // 
            // btn_top_menu3
            // 
            this.btn_top_menu3.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_top_menu3.Location = new System.Drawing.Point(228, 8);
            this.btn_top_menu3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_top_menu3.Name = "btn_top_menu3";
            this.btn_top_menu3.Size = new System.Drawing.Size(86, 54);
            this.btn_top_menu3.TabIndex = 11;
            this.btn_top_menu3.Text = "식사류";
            this.btn_top_menu3.UseVisualStyleBackColor = true;
            // 
            // btn_call
            // 
            this.btn_call.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_call.Location = new System.Drawing.Point(12, 17);
            this.btn_call.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(114, 32);
            this.btn_call.TabIndex = 13;
            this.btn_call.Text = "직원호출";
            this.btn_call.UseVisualStyleBackColor = true;
            this.btn_call.Click += new System.EventHandler(this.btn_call_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_cart.AutoSize = true;
            this.btn_cart.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_cart.Location = new System.Drawing.Point(680, 10);
            this.btn_cart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(108, 32);
            this.btn_cart.TabIndex = 2;
            this.btn_cart.Text = "장바구니";
            this.btn_cart.UseVisualStyleBackColor = true;
            this.btn_cart.CheckedChanged += new System.EventHandler(this.btn_cart_CheckedChanged);
            // 
            // panel_cart
            // 
            this.panel_cart.AutoScroll = true;
            this.panel_cart.BackColor = System.Drawing.Color.White;
            this.panel_cart.Location = new System.Drawing.Point(526, -1);
            this.panel_cart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_cart.Name = "panel_cart";
            this.panel_cart.Size = new System.Drawing.Size(274, 396);
            this.panel_cart.TabIndex = 12;
            this.panel_cart.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 800);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(132, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 326);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btn_admin);
            this.panel2.Controls.Add(this.btn_top_menu1);
            this.panel2.Controls.Add(this.btn_top_menu3);
            this.panel2.Controls.Add(this.btn_top_menu2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 69);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOlist);
            this.panel3.Controls.Add(this.btn_call);
            this.panel3.Controls.Add(this.btn_cart);
            this.panel3.Controls.Add(this.btnBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 55);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_left_menu1);
            this.panel4.Controls.Add(this.btn_left_menu4);
            this.panel4.Controls.Add(this.btn_left_menu2);
            this.panel4.Controls.Add(this.btn_left_menu3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 326);
            this.panel4.TabIndex = 0;
            // 
            // btn_left_menu3
            // 
            this.btn_left_menu3.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_left_menu3.Location = new System.Drawing.Point(9, 104);
            this.btn_left_menu3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left_menu3.Name = "btn_left_menu3";
            this.btn_left_menu3.Size = new System.Drawing.Size(114, 41);
            this.btn_left_menu3.TabIndex = 4;
            this.btn_left_menu3.Text = "주류";
            this.btn_left_menu3.UseVisualStyleBackColor = true;
            // 
            // btn_left_menu2
            // 
            this.btn_left_menu2.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_left_menu2.Location = new System.Drawing.Point(9, 55);
            this.btn_left_menu2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left_menu2.Name = "btn_left_menu2";
            this.btn_left_menu2.Size = new System.Drawing.Size(114, 41);
            this.btn_left_menu2.TabIndex = 3;
            this.btn_left_menu2.Text = "음료";
            this.btn_left_menu2.UseVisualStyleBackColor = true;
            // 
            // btn_left_menu4
            // 
            this.btn_left_menu4.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_left_menu4.Location = new System.Drawing.Point(9, 153);
            this.btn_left_menu4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left_menu4.Name = "btn_left_menu4";
            this.btn_left_menu4.Size = new System.Drawing.Size(114, 41);
            this.btn_left_menu4.TabIndex = 5;
            this.btn_left_menu4.Text = "추가메뉴";
            this.btn_left_menu4.UseVisualStyleBackColor = true;
            // 
            // btn_left_menu1
            // 
            this.btn_left_menu1.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_left_menu1.Location = new System.Drawing.Point(9, 6);
            this.btn_left_menu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left_menu1.Name = "btn_left_menu1";
            this.btn_left_menu1.Size = new System.Drawing.Size(114, 41);
            this.btn_left_menu1.TabIndex = 2;
            this.btn_left_menu1.Text = "메인메뉴";
            this.btn_left_menu1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 133);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(265, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 133);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(483, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 133);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_cart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlist;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btn_call;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_top_menu1;
        private System.Windows.Forms.Button btn_top_menu2;
        private System.Windows.Forms.Button btn_top_menu3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_cart;
        private System.Windows.Forms.CheckBox btn_cart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_left_menu1;
        private System.Windows.Forms.Button btn_left_menu4;
        private System.Windows.Forms.Button btn_left_menu2;
        private System.Windows.Forms.Button btn_left_menu3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

