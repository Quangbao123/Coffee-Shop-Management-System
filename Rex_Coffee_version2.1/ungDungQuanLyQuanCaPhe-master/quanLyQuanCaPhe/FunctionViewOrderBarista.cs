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
    public partial class FunctionViewOrderBarista : DevExpress.XtraEditors.XtraForm
    {
        public FunctionViewOrderBarista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FunctionViewOrderBarista_Load(object sender, EventArgs e)
        {
            label1.Text = "Hiện tại không có món nào được đặt.";
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label1.Visible = true;
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}