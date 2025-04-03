namespace quanLyQuanCaPhe
{
    partial class frm_themqr
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.PictureBox picQRCode;
        private DevExpress.XtraEditors.SimpleButton btnAddQRCode;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_themqr));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnAddQRCode = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(600, 400);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 50);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(200, 400);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(150, 50);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Thêm mới mã";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(350, 150);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(200, 27);
            this.txtTableNumber.TabIndex = 2;
            this.txtTableNumber.Visible = false;
            // 
            // picQRCode
            // 
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQRCode.Location = new System.Drawing.Point(350, 200);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(200, 200);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCode.TabIndex = 1;
            this.picQRCode.TabStop = false;
            this.picQRCode.Visible = false;
            // 
            // btnAddQRCode
            // 
            this.btnAddQRCode.Location = new System.Drawing.Point(350, 420);
            this.btnAddQRCode.Name = "btnAddQRCode";
            this.btnAddQRCode.Size = new System.Drawing.Size(200, 50);
            this.btnAddQRCode.TabIndex = 0;
            this.btnAddQRCode.Text = "Tạo mã QR";
            this.btnAddQRCode.Visible = false;
            this.btnAddQRCode.Click += new System.EventHandler(this.btnAddQRCode_Click);
            // 
            // frm_themqr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnAddQRCode);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.txtTableNumber);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_themqr.IconOptions.Image")));
            this.Name = "frm_themqr";
            this.Text = "Tạo QR code";
            this.Load += new System.EventHandler(this.frm_themqr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
