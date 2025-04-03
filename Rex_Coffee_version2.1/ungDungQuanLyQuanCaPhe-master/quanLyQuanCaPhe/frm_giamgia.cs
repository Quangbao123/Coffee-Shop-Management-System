using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_giamgia : DevExpress.XtraEditors.XtraForm
    {
        public frm_giamgia()
        {
            InitializeComponent();
        }

        private void frm_giamgia_Load(object sender, EventArgs e)
        {
            // Mã giả để điền vào DataGridView ban đầu
            dataGridView1.Rows.Add("Bò húc", 15000);
            dataGridView1.Rows.Add("Trà sữa", 15000);
            dataGridView1.Rows.Add("Cacao nóng", 15000);
            dataGridView1.Rows.Add("Đen đường", 15000);
            dataGridView1.Rows.Add("Trà líp tông", 15000);
            dataGridView1.Rows.Add("Trà gừng", 15000);
            dataGridView1.Rows.Add("Coca Cola", 15000);
            dataGridView1.Rows.Add("Pepsi", 15000);
            dataGridView1.Rows.Add("Aquarius", 15000);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn món hay chưa
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cần chọn món để giảm giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Lấy món đã chọn
                string selectedItem = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                int currentPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column4"].Value);

                // Hiển thị giá hiện tại và yêu cầu nhập giá giảm
                string input = XtraInputBox.Show($"Nhập giá giảm cho món {selectedItem} (Giá hiện tại: {currentPrice} VND):", "Giảm Giá", "0");

                // Kiểm tra giá nhập vào hợp lệ
                if (int.TryParse(input, out int discountPrice) && discountPrice >= 0 && discountPrice < currentPrice)
                {
                    // Cập nhật giá sau khi giảm
                    int newPrice = currentPrice - discountPrice;
                    dataGridView1.SelectedRows[0].Cells["Column4"].Value = newPrice;
                    MessageBox.Show("Giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giá giảm không hợp lệ hoặc quá cao.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Thực hiện cập nhật khi nhấn "Cập nhật"
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cần chọn món để cập nhật giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Cập nhật giá mới
                string selectedItem = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                int newPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column4"].Value);
                MessageBox.Show($"Giá của món {selectedItem} đã được cập nhật thành {newPrice} VND.", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
