using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanLyQuanCaPhe
{
    public partial class frm_cntk : DevExpress.XtraEditors.XtraForm
    {
        public frm_cntk()
        {
            InitializeComponent();

            // Thêm dữ liệu mẫu
            dataGridView1.Rows.Add("1", "Nguyễn Văn A", "01/01/1990", "Nam", "Quản lý");
            dataGridView1.Rows.Add("2", "Trần Thị B", "15/03/1992", "Nữ", "Nhân viên");
            dataGridView1.Rows.Add("3", "Lê Văn C", "20/05/1988", "Nam", "Pha chế");
            dataGridView1.Rows.Add("4", "Phạm Thị D", "12/07/1995", "Nữ", "Thu ngân");

            // Cấu hình DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = false;
        }

        private void frm_cntk_Load(object sender, EventArgs e)
        {
            // Không cần xử lý gì thêm
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra dòng hợp lệ
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells["Column1"].Value?.ToString();
                txtVịTrí.Text = selectedRow.Cells["Column2"].Value?.ToString();
                txtSLGhế.Text = selectedRow.Cells["Column3"].Value?.ToString();
                txtTrạngThái.Text = selectedRow.Cells["Column4"].Value?.ToString();
                textBox1.Text = selectedRow.Cells["Column5"].Value?.ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtVịTrí.Text) ||
                    string.IsNullOrEmpty(txtSLGhế.Text) || string.IsNullOrEmpty(txtTrạngThái.Text) ||
                    string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Column1"].Value = txtID.Text;
                selectedRow.Cells["Column2"].Value = txtVịTrí.Text;
                selectedRow.Cells["Column3"].Value = txtSLGhế.Text;
                selectedRow.Cells["Column4"].Value = txtTrạngThái.Text;
                selectedRow.Cells["Column5"].Value = textBox1.Text;

                MessageBox.Show("Dữ liệu đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
