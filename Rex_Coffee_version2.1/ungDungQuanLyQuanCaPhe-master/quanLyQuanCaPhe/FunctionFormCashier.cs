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
    public partial class FunctionFormCashier : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FunctionFormCashier()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            
            CashierViewOrderList cashierViewOrderList = new CashierViewOrderList();
            cashierViewOrderList.FormClosing += (s, args) => this.Show();
            cashierViewOrderList.ShowDialog();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            
            CashierIssueInvoice cashierIssueInvoice = new CashierIssueInvoice();
            cashierIssueInvoice.FormClosing += (s, args) => this.Show();
            cashierIssueInvoice.ShowDialog();
        }
    }
}
