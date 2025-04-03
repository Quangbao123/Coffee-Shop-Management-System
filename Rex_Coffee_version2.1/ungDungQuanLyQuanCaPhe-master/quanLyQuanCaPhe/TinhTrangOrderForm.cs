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
    public partial class TinhTrangOrderForm : DevExpress.XtraEditors.XtraForm
    {
        private void active()
        {
            this.Hide();
            FunctionStatusOrderWaiter ds = new FunctionStatusOrderWaiter();
            ds.FormClosing += (s, args) => this.Show();
            ds.ShowDialog();
        }
        public TinhTrangOrderForm()
        {
            InitializeComponent();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            active();
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            active();
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e) => active();

        private void checkButton4_CheckedChanged(object sender, EventArgs e) => active();

        private void checkButton5_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton6_CheckedChanged(object sender, EventArgs e)=> active();
        private void checkButton7_CheckedChanged(object sender, EventArgs e)=> active();
        private void checkButton8_CheckedChanged(object sender, EventArgs e)=>active();
        private void checkButton9_CheckedChanged(object sender, EventArgs e)=> active();
        private void checkButton10_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton11_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton13_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton15_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton17_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton19_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton12_CheckedChanged(object sender, EventArgs e)=> active();

        private void checkButton14_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton16_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton18_CheckedChanged(object sender, EventArgs e) => active();
        private void checkButton20_CheckedChanged(object sender, EventArgs e) => active();
    }
}