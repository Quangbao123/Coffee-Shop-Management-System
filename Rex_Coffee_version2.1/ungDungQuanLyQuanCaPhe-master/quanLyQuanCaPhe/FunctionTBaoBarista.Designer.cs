namespace quanLyQuanCaPhe
{
    partial class FunctionTBaoBarista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionTBaoBarista));
            this.label1 = new System.Windows.Forms.Label();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // checkButton1
            // 
            this.checkButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("checkButton1.ImageOptions.SvgImage")));
            this.checkButton1.Location = new System.Drawing.Point(12, 615);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(56, 52);
            this.checkButton1.TabIndex = 4;
            this.checkButton1.Text = "checkButton1";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // FunctionTBaoBarista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 679);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FunctionTBaoBarista.IconOptions.Image")));
            this.Name = "FunctionTBaoBarista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.FunctionTBaoBarista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
    }
}