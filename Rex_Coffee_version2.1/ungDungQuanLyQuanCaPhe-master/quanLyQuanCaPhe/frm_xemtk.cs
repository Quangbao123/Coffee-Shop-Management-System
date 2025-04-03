using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_xemtk : DevExpress.XtraEditors.XtraForm
    {
        public frm_xemtk()
        {
            InitializeComponent();
            // Thêm dữ liệu mẫu vào DataGridView
            dataGridView1.Rows.Add("1", "Nguyễn Văn A", "01/01/1990", "Nam", "Quản lý");
            dataGridView1.Rows.Add("2", "Trần Thị B", "15/03/1992", "Nữ", "Nhân viên");
            dataGridView1.Rows.Add("3", "Lê Văn C", "20/05/1988", "Nam", "Pha chế");
            dataGridView1.Rows.Add("4", "Phạm Thị D", "12/07/1995", "Nữ", "Thu ngân");
        }

        private void frm_xemtk_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_xemtk_Load_1(object sender, EventArgs e)
        {

        }
    }
}
