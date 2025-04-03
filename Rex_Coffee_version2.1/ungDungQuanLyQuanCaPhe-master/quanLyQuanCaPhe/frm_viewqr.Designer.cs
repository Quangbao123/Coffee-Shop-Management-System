namespace quanLyQuanCaPhe
{
    partial class frm_viewqr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_viewqr));
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageSlider3 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageSlider4 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(24, 12);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(144, 127);
            this.imageSlider1.TabIndex = 7;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // imageSlider2
            // 
            this.imageSlider2.CurrentImageIndex = 0;
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images"))));
            this.imageSlider2.Location = new System.Drawing.Point(24, 181);
            this.imageSlider2.Name = "imageSlider2";
            this.imageSlider2.Size = new System.Drawing.Size(144, 127);
            this.imageSlider2.TabIndex = 8;
            this.imageSlider2.Text = "imageSlider2";
            // 
            // imageSlider3
            // 
            this.imageSlider3.CurrentImageIndex = 0;
            this.imageSlider3.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider3.Images"))));
            this.imageSlider3.Location = new System.Drawing.Point(488, 12);
            this.imageSlider3.Name = "imageSlider3";
            this.imageSlider3.Size = new System.Drawing.Size(144, 127);
            this.imageSlider3.TabIndex = 9;
            this.imageSlider3.Text = "imageSlider3";
            // 
            // imageSlider4
            // 
            this.imageSlider4.CurrentImageIndex = 0;
            this.imageSlider4.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider4.Images"))));
            this.imageSlider4.Location = new System.Drawing.Point(488, 194);
            this.imageSlider4.Name = "imageSlider4";
            this.imageSlider4.Size = new System.Drawing.Size(144, 127);
            this.imageSlider4.TabIndex = 10;
            this.imageSlider4.Text = "imageSlider4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "bàn 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "bàn 2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(737, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "bàn 3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(737, 260);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 27);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "bàn 4";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(510, 416);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 34);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_viewqr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 515);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageSlider4);
            this.Controls.Add(this.imageSlider3);
            this.Controls.Add(this.imageSlider2);
            this.Controls.Add(this.imageSlider1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_viewqr.IconOptions.Image")));
            this.Name = "frm_viewqr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem danh sách mã QR";
            this.Load += new System.EventHandler(this.frm_viewqr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider2;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider3;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}