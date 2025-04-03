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
    public partial class FunctionFormBarista : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FunctionFormBarista()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            
            FunctionViewOrderBarista viewOrderBarista = new FunctionViewOrderBarista();
            viewOrderBarista.FormClosing += (s, args) => this.Show();
            viewOrderBarista.ShowDialog();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            
            FunctionTBaoBarista tBaoBarista = new FunctionTBaoBarista();
            tBaoBarista.FormClosing += (s, args) => this.Show();
            tBaoBarista.ShowDialog();
        }
    }
}
