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
            this.btn_oList = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_top_menu3 = new System.Windows.Forms.Button();
            this.btn_top_menu1 = new System.Windows.Forms.Button();
            this.btn_top_menu2 = new System.Windows.Forms.Button();
            this.btn_call = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.CheckBox();
            this.panel_cart = new System.Windows.Forms.Panel();
            this.panel_center = new System.Windows.Forms.Panel();
            this.main_line4 = new System.Windows.Forms.Panel();
            this.main_line5 = new System.Windows.Forms.Panel();
            this.lbl_food3 = new System.Windows.Forms.Label();
            this.lbl_food1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_food2 = new System.Windows.Forms.Label();
            this.main_line2 = new System.Windows.Forms.Panel();
            this.main_line3 = new System.Windows.Forms.Panel();
            this.main_line1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_left_menu1 = new System.Windows.Forms.Button();
            this.btn_left_menu4 = new System.Windows.Forms.Button();
            this.btn_left_menu2 = new System.Windows.Forms.Button();
            this.btn_left_menu3 = new System.Windows.Forms.Button();
            this.lbl_drink = new System.Windows.Forms.Label();
            this.main_line6 = new System.Windows.Forms.Panel();
            this.lbl_alcohol = new System.Windows.Forms.Label();
            this.lbl_side = new System.Windows.Forms.Label();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_oList
            // 
            this.btn_oList.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_oList.Location = new System.Drawing.Point(474, 10);
            this.btn_oList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_oList.Name = "btn_oList";
            this.btn_oList.Size = new System.Drawing.Size(108, 32);
            this.btn_oList.TabIndex = 0;
            this.btn_oList.Text = "주문내역";
            this.btn_oList.UseVisualStyleBackColor = true;
            this.btn_oList.Click += new System.EventHandler(this.btn_oList_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_bill.Location = new System.Drawing.Point(588, 10);
            this.btn_bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(86, 32);
            this.btn_bill.TabIndex = 1;
            this.btn_bill.Text = "계산서";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
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
            // btn_top_menu3
            // 
            this.btn_top_menu3.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_top_menu3.Location = new System.Drawing.Point(320, 8);
            this.btn_top_menu3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_top_menu3.Name = "btn_top_menu3";
            this.btn_top_menu3.Size = new System.Drawing.Size(86, 54);
            this.btn_top_menu3.TabIndex = 9;
            this.btn_top_menu3.Text = "튀김";
            this.btn_top_menu3.UseVisualStyleBackColor = true;
            this.btn_top_menu3.Click += new System.EventHandler(this.btn_top_menu3_Click);
            // 
            // btn_top_menu1
            // 
            this.btn_top_menu1.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_top_menu1.Location = new System.Drawing.Point(136, 8);
            this.btn_top_menu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_top_menu1.Name = "btn_top_menu1";
            this.btn_top_menu1.Size = new System.Drawing.Size(86, 54);
            this.btn_top_menu1.TabIndex = 10;
            this.btn_top_menu1.Text = "탕";
            this.btn_top_menu1.UseVisualStyleBackColor = true;
            this.btn_top_menu1.Click += new System.EventHandler(this.btn_top_menu1_Click);
            // 
            // btn_top_menu2
            // 
            this.btn_top_menu2.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_top_menu2.Location = new System.Drawing.Point(228, 8);
            this.btn_top_menu2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_top_menu2.Name = "btn_top_menu2";
            this.btn_top_menu2.Size = new System.Drawing.Size(86, 54);
            this.btn_top_menu2.TabIndex = 11;
            this.btn_top_menu2.Text = "식사류";
            this.btn_top_menu2.UseVisualStyleBackColor = true;
            this.btn_top_menu2.Click += new System.EventHandler(this.btn_top_menu2_Click);
            // 
            // btn_call
            // 
            this.btn_call.Font = new System.Drawing.Font("굴림", 13F);
            this.btn_call.Location = new System.Drawing.Point(8, 10);
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
            // panel_center
            // 
            this.panel_center.AutoScroll = true;
            this.panel_center.AutoScrollMinSize = new System.Drawing.Size(0, 4500);
            this.panel_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_center.Controls.Add(this.lbl_side);
            this.panel_center.Controls.Add(this.lbl_alcohol);
            this.panel_center.Controls.Add(this.main_line6);
            this.panel_center.Controls.Add(this.lbl_drink);
            this.panel_center.Controls.Add(this.lbl_food3);
            this.panel_center.Controls.Add(this.main_line3);
            this.panel_center.Controls.Add(this.main_line5);
            this.panel_center.Controls.Add(this.main_line4);
            this.panel_center.Controls.Add(this.lbl_food1);
            this.panel_center.Controls.Add(this.pictureBox9);
            this.panel_center.Controls.Add(this.pictureBox8);
            this.panel_center.Controls.Add(this.pictureBox7);
            this.panel_center.Controls.Add(this.pictureBox6);
            this.panel_center.Controls.Add(this.pictureBox5);
            this.panel_center.Controls.Add(this.pictureBox4);
            this.panel_center.Controls.Add(this.lbl_food2);
            this.panel_center.Controls.Add(this.main_line2);
            this.panel_center.Controls.Add(this.main_line1);
            this.panel_center.Controls.Add(this.pictureBox2);
            this.panel_center.Controls.Add(this.pictureBox3);
            this.panel_center.Controls.Add(this.pictureBox1);
            this.panel_center.Location = new System.Drawing.Point(132, 67);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(668, 331);
            this.panel_center.TabIndex = 3;
            // 
            // main_line4
            // 
            this.main_line4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_line4.Location = new System.Drawing.Point(70, 2210);
            this.main_line4.Margin = new System.Windows.Forms.Padding(0);
            this.main_line4.Name = "main_line4";
            this.main_line4.Size = new System.Drawing.Size(566, 2);
            this.main_line4.TabIndex = 16;
            // 
            // main_line5
            // 
            this.main_line5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_line5.Location = new System.Drawing.Point(70, 2935);
            this.main_line5.Margin = new System.Windows.Forms.Padding(0);
            this.main_line5.Name = "main_line5";
            this.main_line5.Size = new System.Drawing.Size(566, 2);
            this.main_line5.TabIndex = 15;
            // 
            // lbl_food3
            // 
            this.lbl_food3.AutoSize = true;
            this.lbl_food3.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_food3.Location = new System.Drawing.Point(10, 1465);
            this.lbl_food3.Name = "lbl_food3";
            this.lbl_food3.Size = new System.Drawing.Size(83, 34);
            this.lbl_food3.TabIndex = 22;
            this.lbl_food3.Text = "튀김";
            // 
            // lbl_food1
            // 
            this.lbl_food1.AutoSize = true;
            this.lbl_food1.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_food1.Location = new System.Drawing.Point(10, 15);
            this.lbl_food1.Name = "lbl_food1";
            this.lbl_food1.Size = new System.Drawing.Size(49, 34);
            this.lbl_food1.TabIndex = 12;
            this.lbl_food1.Text = "탕";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(493, 515);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(134, 133);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(259, 515);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(131, 133);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(25, 515);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(132, 133);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(493, 290);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(134, 133);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(259, 290);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 133);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 133);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_food2
            // 
            this.lbl_food2.AutoSize = true;
            this.lbl_food2.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_food2.Location = new System.Drawing.Point(10, 740);
            this.lbl_food2.Name = "lbl_food2";
            this.lbl_food2.Size = new System.Drawing.Size(117, 34);
            this.lbl_food2.TabIndex = 15;
            this.lbl_food2.Text = "식사류";
            // 
            // main_line2
            // 
            this.main_line2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_line2.Location = new System.Drawing.Point(70, 760);
            this.main_line2.Margin = new System.Windows.Forms.Padding(0);
            this.main_line2.Name = "main_line2";
            this.main_line2.Size = new System.Drawing.Size(566, 2);
            this.main_line2.TabIndex = 14;
            // 
            // main_line3
            // 
            this.main_line3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_line3.Location = new System.Drawing.Point(70, 1485);
            this.main_line3.Margin = new System.Windows.Forms.Padding(0);
            this.main_line3.Name = "main_line3";
            this.main_line3.Size = new System.Drawing.Size(566, 2);
            this.main_line3.TabIndex = 15;
            // 
            // main_line1
            // 
            this.main_line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_line1.Location = new System.Drawing.Point(21, 35);
            this.main_line1.Margin = new System.Windows.Forms.Padding(0);
            this.main_line1.Name = "main_line1";
            this.main_line1.Size = new System.Drawing.Size(615, 2);
            this.main_line1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(493, 65);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 133);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 65);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 133);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 133);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel_top
            // 
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_top.Controls.Add(this.pic_logo);
            this.panel_top.Controls.Add(this.btn_admin);
            this.panel_top.Controls.Add(this.btn_top_menu3);
            this.panel_top.Controls.Add(this.btn_top_menu2);
            this.panel_top.Controls.Add(this.btn_top_menu1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 69);
            this.panel_top.TabIndex = 0;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.ImageLocation = "";
            this.pic_logo.Location = new System.Drawing.Point(3, 3);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(127, 63);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 12;
            this.pic_logo.TabStop = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bottom.Controls.Add(this.btn_oList);
            this.panel_bottom.Controls.Add(this.btn_call);
            this.panel_bottom.Controls.Add(this.btn_cart);
            this.panel_bottom.Controls.Add(this.btn_bill);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 395);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(800, 55);
            this.panel_bottom.TabIndex = 0;
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.btn_left_menu1);
            this.panel_left.Controls.Add(this.btn_left_menu4);
            this.panel_left.Controls.Add(this.btn_left_menu2);
            this.panel_left.Controls.Add(this.btn_left_menu3);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 69);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(132, 326);
            this.panel_left.TabIndex = 0;
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
            this.btn_left_menu1.Click += new System.EventHandler(this.btn_left_menu1_Click);
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
            this.btn_left_menu4.Click += new System.EventHandler(this.btn_left_menu4_Click);
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
            this.btn_left_menu2.Click += new System.EventHandler(this.btn_left_menu2_Click);
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
            this.btn_left_menu3.Click += new System.EventHandler(this.btn_left_menu3_Click);
            // 
            // lbl_drink
            // 
            this.lbl_drink.AutoSize = true;
            this.lbl_drink.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_drink.Location = new System.Drawing.Point(10, 2190);
            this.lbl_drink.Name = "lbl_drink";
            this.lbl_drink.Size = new System.Drawing.Size(83, 34);
            this.lbl_drink.TabIndex = 23;
            this.lbl_drink.Text = "음료";
            // 
            // main_line6
            // 
            this.main_line6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_line6.Location = new System.Drawing.Point(70, 3660);
            this.main_line6.Margin = new System.Windows.Forms.Padding(0);
            this.main_line6.Name = "main_line6";
            this.main_line6.Size = new System.Drawing.Size(566, 2);
            this.main_line6.TabIndex = 16;
            // 
            // lbl_alcohol
            // 
            this.lbl_alcohol.AutoSize = true;
            this.lbl_alcohol.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_alcohol.Location = new System.Drawing.Point(10, 2915);
            this.lbl_alcohol.Name = "lbl_alcohol";
            this.lbl_alcohol.Size = new System.Drawing.Size(83, 34);
            this.lbl_alcohol.TabIndex = 24;
            this.lbl_alcohol.Text = "주류";
            // 
            // lbl_side
            // 
            this.lbl_side.AutoSize = true;
            this.lbl_side.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_side.Location = new System.Drawing.Point(10, 3640);
            this.lbl_side.Name = "lbl_side";
            this.lbl_side.Size = new System.Drawing.Size(151, 34);
            this.lbl_side.TabIndex = 25;
            this.lbl_side.Text = "추가메뉴";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel_cart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_oList;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_call;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_top_menu3;
        private System.Windows.Forms.Button btn_top_menu1;
        private System.Windows.Forms.Button btn_top_menu2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_cart;
        private System.Windows.Forms.CheckBox btn_cart;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_left_menu1;
        private System.Windows.Forms.Button btn_left_menu4;
        private System.Windows.Forms.Button btn_left_menu2;
        private System.Windows.Forms.Button btn_left_menu3;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel main_line1;
        private System.Windows.Forms.Label lbl_food1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_food2;
        private System.Windows.Forms.Panel main_line2;
        private System.Windows.Forms.Panel main_line3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel main_line4;
        private System.Windows.Forms.Panel main_line5;
        private System.Windows.Forms.Label lbl_food3;
        private System.Windows.Forms.Label lbl_side;
        private System.Windows.Forms.Label lbl_alcohol;
        private System.Windows.Forms.Panel main_line6;
        private System.Windows.Forms.Label lbl_drink;
    }
}

