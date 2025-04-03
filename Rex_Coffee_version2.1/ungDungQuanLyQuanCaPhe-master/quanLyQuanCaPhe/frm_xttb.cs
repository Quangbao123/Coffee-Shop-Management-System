using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_xttb : DevExpress.XtraEditors.XtraForm
    {
        public frm_xttb()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1, "Khu vực A", 4, "Trống");
            dataGridView1.Rows.Add(2, "Khu vực B", 6, "Đang sử dụng");
            dataGridView1.Rows.Add(3, "Khu vực C", 2, "Đã đặt trước");
            dataGridView1.Rows.Add(4, "Khu vực D", 8, "Trống");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hiển thị thông báo xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa dòng được chọn
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow) // Bảo vệ dòng trống không bị xóa
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                    }

                    MessageBox.Show("Đã xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_xttb_Load(object sender, EventArgs e)
        {

        }
    }
}