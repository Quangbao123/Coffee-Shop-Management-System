using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_xtk : DevExpress.XtraEditors.XtraForm
    {
        public frm_xtk()
        {
            InitializeComponent();
            dataGridView2.Rows.Add("1", "Nguyễn Văn A", "01/01/1990", "Nam", "Quản lý");
            dataGridView2.Rows.Add("2", "Trần Thị B", "15/03/1992", "Nữ", "Nhân viên");
            dataGridView2.Rows.Add("3", "Lê Văn C", "20/05/1988", "Nam", "Pha chế");
            dataGridView2.Rows.Add("4", "Phạm Thị D", "12/07/1995", "Nữ", "Thu ngân");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Xác nhận xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lấy chỉ số dòng được chọn và xóa
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.Remove(row);
                    }

                    // Thông báo đã xóa thành công
                    MessageBox.Show("Tài khoản đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
