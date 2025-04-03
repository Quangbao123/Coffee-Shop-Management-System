using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class FunctionFormWaiter : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FunctionFormWaiter()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            
            FunctionTBPVWaiter tbpv = new FunctionTBPVWaiter();
            tbpv.FormClosing += (s, args) => this.Show();
            _ = tbpv.ShowDialog();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            // form xem tinh trang order cua waiter
            
            TinhTrangOrderForm tinhTrangOrderForm = new TinhTrangOrderForm();
            tinhTrangOrderForm.FormClosing += (s, args) => this.Show();
            tinhTrangOrderForm.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
