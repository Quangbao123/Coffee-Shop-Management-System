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
    public partial class LoginFormWaiter : DevExpress.XtraEditors.XtraForm
    {
        public LoginFormWaiter()
        {
            InitializeComponent();
        }

        private void LoginFormNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FunctionFormWaiter fwt = new FunctionFormWaiter();
            fwt.FormClosing += (s, args) => this.Show();
            fwt.ShowDialog();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            // dong login form
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
    }
}