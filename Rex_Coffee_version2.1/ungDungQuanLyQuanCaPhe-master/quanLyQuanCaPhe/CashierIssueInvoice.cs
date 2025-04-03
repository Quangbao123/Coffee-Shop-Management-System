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
    public partial class CashierIssueInvoice : DevExpress.XtraEditors.XtraForm
    {
        public CashierIssueInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashierIssueInvoice_Load(object sender, EventArgs e)
        {
            label1.Text = "Hiện tại không có món nào được đặt.";
            label1.Font = new Font("Arial", 10, FontStyle.Bold);
            label1.Visible = true;
        }
    }
}