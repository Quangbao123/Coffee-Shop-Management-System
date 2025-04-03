using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_cnmenu : DevExpress.XtraEditors.XtraForm
    {
        public frm_cnmenu()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("1", "trà đào", "2", "15.000vnd");
            dataGridView1.Rows.Add("2", "trà sữa", "10", "15.000vnd");
            dataGridView1.Rows.Add("3", "Aquarius", "5", "15.000vnd");
            dataGridView1.Rows.Add("4", "cacao nóng", "3", "15.000vnd");

            // Gán sự kiện cho DataGridView
            dataGridView1.CellClick += DataGridView1_CellClick;

            // Gán sự kiện cho nút "Cập nhật"
            simpleButton1.Click += SimpleButton1_Click;
        }

        private void frm_cnmenu_Load(object sender, EventArgs e)
        {
            // Không cần xử lý gì ở đây
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện khi người dùng chọn một ô trong DataGridView
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra nếu hàng được chọn không phải tiêu đề
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Gán giá trị của hàng vào các ô nhập liệu
                    txtID.Text = row.Cells[0].Value?.ToString();
                    txtVịTrí.Text = row.Cells[1].Value?.ToString();
                    txtSLGhế.Text = row.Cells[2].Value?.ToString();
                    txtTrạngThái.Text = row.Cells[3].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Cập nhật"
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy hàng được chọn
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Cập nhật giá trị vào hàng
                    selectedRow.Cells[0].Value = txtID.Text;
                    selectedRow.Cells[1].Value = txtVịTrí.Text;
                    selectedRow.Cells[2].Value = txtSLGhế.Text;
                    selectedRow.Cells[3].Value = txtTrạngThái.Text;

                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
