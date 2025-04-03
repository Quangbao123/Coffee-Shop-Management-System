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
    public partial class frmOptions : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMenu nv = new frmMenu();

            nv.FormClosing += (s, args) =>
            {

                this.Show();
            };
            nv.ShowDialog();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDSB nv = new frmDSB();

            nv.FormClosing += (s, args) =>
            {

                this.Show();
            };
            nv.ShowDialog();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDS nv = new frmDS();

            nv.FormClosing += (s, args) =>
            {

                this.Show();
            };
            nv.ShowDialog();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
