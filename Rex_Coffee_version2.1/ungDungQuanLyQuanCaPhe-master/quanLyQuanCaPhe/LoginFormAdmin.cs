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
    public partial class LoginFormAdmin : DevExpress.XtraEditors.XtraForm
    {
        public LoginFormAdmin()
        {
            InitializeComponent();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            // mo form dat lai mat khau
            EmailForm FPform = new EmailForm();
            FPform.FormClosing += (s, args) =>
            {
                this.Show();
            };
            FPform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FunctionFormAdmin formAdmin = new FunctionFormAdmin();
            formAdmin.FormClosing += (s, args) => this.Show();
            formAdmin.ShowDialog();
        }
    }
}