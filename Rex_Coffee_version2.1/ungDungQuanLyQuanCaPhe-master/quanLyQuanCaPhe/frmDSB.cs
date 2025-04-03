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
    public partial class frmDSB : DevExpress.XtraEditors.XtraForm
    {
        public frmDSB()
        {
            InitializeComponent();
        }

        private void frmDSB_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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