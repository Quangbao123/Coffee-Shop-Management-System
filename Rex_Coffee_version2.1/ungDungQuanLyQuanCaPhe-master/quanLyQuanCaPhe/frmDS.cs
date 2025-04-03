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
    public partial class frmDS : DevExpress.XtraEditors.XtraForm
    {
        public frmDS()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmOptions nv = new frmOptions();

            nv.FormClosing += (s, args) =>
            {

                this.ShowDialog();
            };
            nv.ShowDialog();
        }
    }
}