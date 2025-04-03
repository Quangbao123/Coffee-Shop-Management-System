using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_tmenu : DevExpress.XtraEditors.XtraForm
    {
        public frm_tmenu()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("1", "trà đào", "2", "15.000vnd");
            dataGridView1.Rows.Add("2", "trà sữa", "10", "15.000vnd");
            dataGridView1.Rows.Add("3", "Aquarius", "5", "15.000vnd");
            dataGridView1.Rows.Add("4", "cacao nóng", "3", "15.000vnd");

            // Gán sự kiện cho nút "Thêm mới"
            simpleButton1.Click += SimpleButton1_Click;
        }

        private void frm_tmenu_Load(object sender, EventArgs e)
        {
            // Không cần xử lý trong hàm Load
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Thêm một dòng trống vào DataGridView
                dataGridView1.Rows.Add("", "", "", "");
                MessageBox.Show("Thêm dòng mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
