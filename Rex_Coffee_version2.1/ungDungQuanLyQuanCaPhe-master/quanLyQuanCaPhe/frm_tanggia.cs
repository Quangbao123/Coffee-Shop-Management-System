using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_tanggia : DevExpress.XtraEditors.XtraForm
    {
        public frm_tanggia()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_tanggia_Load(object sender, EventArgs e)
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
                MessageBox.Show("Cần chọn món để tăng giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Lấy món đã chọn
                string selectedItem = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                int currentPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column4"].Value);

                // Hiển thị giá hiện tại và yêu cầu nhập giá mới
                string input = XtraInputBox.Show($"Nhập giá mới cho món {selectedItem} (Giá hiện tại: {currentPrice} VND):", "Tăng Giá", currentPrice.ToString());

                // Kiểm tra giá nhập vào hợp lệ
                if (int.TryParse(input, out int newPrice) && newPrice > 0)
                {
                    // Cập nhật giá mới
                    dataGridView1.SelectedRows[0].Cells["Column4"].Value = newPrice;
                    MessageBox.Show("Cập nhật giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giá nhập vào không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
