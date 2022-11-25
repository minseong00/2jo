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
            this.btnOlist = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOlist
            // 
            this.btnOlist.Location = new System.Drawing.Point(427, 325);
            this.btnOlist.Name = "btnOlist";
            this.btnOlist.Size = new System.Drawing.Size(75, 23);
            this.btnOlist.TabIndex = 0;
            this.btnOlist.Text = "주문내역";
            this.btnOlist.UseVisualStyleBackColor = true;
            this.btnOlist.Click += new System.EventHandler(this.btnOlist_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(524, 325);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "계산서";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnOlist);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "메인";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlist;
        private System.Windows.Forms.Button btnBill;
    }
}

