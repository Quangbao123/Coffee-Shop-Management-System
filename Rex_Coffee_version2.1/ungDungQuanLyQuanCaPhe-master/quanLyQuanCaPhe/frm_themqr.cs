using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_themqr : DevExpress.XtraEditors.XtraForm
    {
        public frm_themqr()
        {
            InitializeComponent();
        }

        private void frm_themqr_Load(object sender, EventArgs e)
        {
            // Ẩn các thành phần QR code lúc đầu
            AddQRCodeControls(false);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Hiển thị khu vực nhập số bàn và tạo mã QR
            AddQRCodeControls(true);
        }

        private void btnAddQRCode_Click(object sender, EventArgs e)
        {
            string tableNumber = txtTableNumber.Text.Trim();

            if (string.IsNullOrEmpty(tableNumber))
            {
                MessageBox.Show("Vui lòng nhập số bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
              

              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mã QR: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddQRCodeControls(bool isVisible)
        {
            txtTableNumber.Visible = isVisible;
            picQRCode.Visible = isVisible;
            btnAddQRCode.Visible = isVisible;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }
    }
}
