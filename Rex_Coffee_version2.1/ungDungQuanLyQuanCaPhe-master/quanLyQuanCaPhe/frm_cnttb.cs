using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_cnttb : DevExpress.XtraEditors.XtraForm
    {
        public frm_cnttb()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1, "Khu vực A", 4, "Trống");
            dataGridView1.Rows.Add(2, "Khu vực B", 6, "Đang sử dụng");
            dataGridView1.Rows.Add(3, "Khu vực C", 2, "Đã đặt trước");
            dataGridView1.Rows.Add(4, "Khu vực D", 8, "Trống");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số dòng hợp lệ
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Hiển thị dữ liệu dòng vào các điều khiển nhập liệu
                txtID.Text = selectedRow.Cells["Column1"].Value.ToString();
                txtVịTrí.Text = selectedRow.Cells["Column2"].Value.ToString();
                txtSLGhế.Text = selectedRow.Cells["Column3"].Value.ToString();
                txtTrạngThái.Text = selectedRow.Cells["Column4"].Value.ToString();
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kiểm tra xem người dùng có nhập đủ thông tin hay không
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtVịTrí.Text) ||
                    string.IsNullOrEmpty(txtSLGhế.Text) || string.IsNullOrEmpty(txtTrạngThái.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật dữ liệu vào dòng đã chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Column1"].Value = txtID.Text;
                selectedRow.Cells["Column2"].Value = txtVịTrí.Text;
                selectedRow.Cells["Column3"].Value = txtSLGhế.Text;
                selectedRow.Cells["Column4"].Value = txtTrạngThái.Text;

                MessageBox.Show("Dữ liệu đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_cnttb_Load(object sender, EventArgs e)
        {

        }
    }
}
