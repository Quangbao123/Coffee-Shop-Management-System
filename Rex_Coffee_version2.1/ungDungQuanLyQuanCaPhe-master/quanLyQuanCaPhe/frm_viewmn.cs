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
    public partial class frm_viewmn : DevExpress.XtraEditors.XtraForm
    {
        public frm_viewmn()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("1", "trà đào", "2", "15.000vnd");
            dataGridView1.Rows.Add("2", "trà sữa", "10", "15.000vnd");
            dataGridView1.Rows.Add("3", "Aquarius", "5", "15.000vnd");
            dataGridView1.Rows.Add("4", "cacao nóng", "3", "15.000vnd");
        }

        private void frm_xemtk_Load_1(object sender, EventArgs  e)
        {
            // Thêm các hàng vào dataGridView1
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_viewmn_Load(object sender, EventArgs e)
        {

        }
    }
}