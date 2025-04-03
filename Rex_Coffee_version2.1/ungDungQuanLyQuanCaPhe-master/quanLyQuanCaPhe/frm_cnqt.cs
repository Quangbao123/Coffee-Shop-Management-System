using System;
using System.IO;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_cnqt : DevExpress.XtraEditors.XtraForm
    {
        private string selectedImagePath;

        public frm_cnqt()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            UpdateQR();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            UpdateQR();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            UpdateQR();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UpdateTableInfo();
        }

        private void UpdateQR()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    MessageBox.Show("QR code image selected. Please update table information if needed.", "QR Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateTableInfo()
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please select a QR code image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string table1 = textBox1.Text;
            string table2 = textBox2.Text;
            string table3 = textBox3.Text;
            string table4 = textBox4.Text;

            // Save or process the updated information
            string message = $"QR updated with the following table information:\n" +
                             $"Table 1: {table1}\nTable 2: {table2}\n" +
                             $"Table 3: {table3}\nTable 4: {table4}";

            MessageBox.Show(message, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cnqt_Load(object sender, EventArgs e)
        {
            // Initial setup if needed
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton4_Click);
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton6_Click);
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
        }
    }
}
