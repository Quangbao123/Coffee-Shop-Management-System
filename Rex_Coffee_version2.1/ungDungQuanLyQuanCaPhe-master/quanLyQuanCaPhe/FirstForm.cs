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
    public partial class FirstForm : DevExpress.XtraEditors.XtraForm
    {
        
        public FirstForm()
        {
            InitializeComponent();
            
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            frmQR nv = new frmQR();

            nv.FormClosing += (s, args) =>
            {
                
                this.Show();
            };
            nv.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            // mo form dang nhap
            LoginFormWaiter wt = new LoginFormWaiter();

            wt.FormClosing += (s, args) =>
            {
                // hien thi lai firstform sau khi dong
                this.Show();
            };
            wt.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFormAdmin ad = new LoginFormAdmin();
            ad.FormClosing += (s, args) => this.Show();
            ad.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            // mo form dang nhap
            LoginFormBarista br = new LoginFormBarista();

            br.FormClosing += (s, args) =>
            {
                // hien thi lai firstform sau khi dong
                this.Show();
            };
            br.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            // mo form dang nhap
            LoginFormCashier cs= new LoginFormCashier();

            cs.FormClosing += (s, args) =>
            {
                // hien thi lai firstform sau khi dong
                this.Show();
            };
            cs.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}