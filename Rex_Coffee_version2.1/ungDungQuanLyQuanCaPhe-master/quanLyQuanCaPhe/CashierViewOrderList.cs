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
    public partial class CashierViewOrderList : DevExpress.XtraEditors.XtraForm
    {
        public CashierViewOrderList()
        {
            InitializeComponent();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashierViewOrderList_Load(object sender, EventArgs e)
        {
            label1.Text = "Hiện tại không có món nào được đặt.";
            label1.Font = new Font("Arial", 10, FontStyle.Bold);
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}