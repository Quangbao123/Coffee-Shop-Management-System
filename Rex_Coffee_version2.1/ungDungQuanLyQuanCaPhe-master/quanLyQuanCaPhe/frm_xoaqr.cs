using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_xoaqr : DevExpress.XtraEditors.XtraForm
    {
        public frm_xoaqr()
        {
            InitializeComponent();
        }

        private void frm_xoaqr_Load(object sender, EventArgs e)
        {
            // Có thể thêm các thiết lập ban đầu tại đây
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ClearInfo(textBox1, imageSlider1);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ClearInfo(textBox2, imageSlider2);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            ClearInfo(textBox3, imageSlider3);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ClearInfo(textBox4, imageSlider4);
        }

        private void ClearInfo(TextBox textBox, DevExpress.XtraEditors.Controls.ImageSlider imageSlider)
        {
            // Xoá nội dung TextBox
            textBox.Clear();
            // Xoá hình ảnh trong ImageSlider
            imageSlider.Images.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            // Gắn sự kiện Click cho các nút xoá
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            

        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            // Gắn sự kiện Click cho các nút xoá
           
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
       

        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            // Gắn sự kiện Click cho các nút xoá
            
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
      

        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            // Gắn sự kiện Click cho các nút xoá
           
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);

          

        }
    }
}
