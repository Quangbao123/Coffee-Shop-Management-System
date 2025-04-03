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
    public partial class frm_viewqr : DevExpress.XtraEditors.XtraForm
    {
        public frm_viewqr()
        {
            InitializeComponent();
        }

        private void frm_viewqr_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}