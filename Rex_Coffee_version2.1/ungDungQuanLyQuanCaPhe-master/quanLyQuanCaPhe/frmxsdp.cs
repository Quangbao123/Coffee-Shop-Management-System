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
    public partial class frmxsdp : DevExpress.XtraEditors.XtraForm
    {
        public frmxsdp()
        {
            InitializeComponent();
            LoadData(); // Gọi hàm để load dữ liệu
        }

        private void LoadData()
        {
            // Thêm 4 dòng dữ liệu mẫu
            dataGridView1.Rows.Add(1, "Khu vực A", 4, "Trống");
            dataGridView1.Rows.Add(2, "Khu vực B", 6, "Đang sử dụng");
            dataGridView1.Rows.Add(3, "Khu vực C", 2, "Đã đặt trước");
            dataGridView1.Rows.Add(4, "Khu vực D", 8, "Trống");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi click vào ô trong DataGridView (nếu cần)
        }

        private void frmxsdp_Load(object sender, EventArgs e)
        {

        }
    }
}
