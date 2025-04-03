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
    public partial class EmailForm : DevExpress.XtraEditors.XtraForm
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORGOTPASSWORDFORM2 FPform2 = new FORGOTPASSWORDFORM2();
            FPform2.FormClosing += (s, args) => this.Show();
            FPform2.ShowDialog();
            this.Close();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}