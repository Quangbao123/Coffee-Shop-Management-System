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
    public partial class frmQR : DevExpress.XtraEditors.XtraForm
    {
        public frmQR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmOptions nv = new frmOptions();

            nv.FormClosing += (s, args) =>
            {

                this.Show();
            };
            nv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FirstForm nv = new FirstForm();

            nv.FormClosing += (s, args) =>
            {

                this.Show();
            };
            nv.ShowDialog();
        }

        private void frmQR_Load(object sender, EventArgs e)
        {

        }
    }
}