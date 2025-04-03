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
    public partial class frm_xoamenu : DevExpress.XtraEditors.XtraForm
    {
        public frm_xoamenu()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("1", "trà đào", "2", "15.000vnd");
            dataGridView1.Rows.Add("2", "trà sữa", "10", "15.000vnd");
            dataGridView1.Rows.Add("3", "Aquarius", "5", "15.000vnd");
            dataGridView1.Rows.Add("4", "cacao nóng", "3", "15.000vnd");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Xóa từng dòng được chọn
                    if (!row.IsNewRow) // Đảm bảo không xóa dòng trống mới
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_xoamenu_Load(object sender, EventArgs e)
        {

        }
    }
}