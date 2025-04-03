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
    public partial class frm_themtk : DevExpress.XtraEditors.XtraForm
    {
        public frm_themtk()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("1", "Nguyễn Văn A", "01/01/1990", "Nam", "Quản lý");
            dataGridView1.Rows.Add("2", "Trần Thị B", "15/03/1992", "Nữ", "Nhân viên");
            dataGridView1.Rows.Add("3", "Lê Văn C", "20/05/1988", "Nam", "Pha chế");
            dataGridView1.Rows.Add("4", "Phạm Thị D", "12/07/1995", "Nữ", "Thu ngân");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 400 };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập thông tin
            string id = Prompt.ShowDialog("Nhập Id :", "Thêm mới");
            string hoten = Prompt.ShowDialog("Nhập họ tên:", "Thêm mới");
            string ngaysinh = Prompt.ShowDialog("Nhập ngày sinh:", "Thêm mới");
            string gioitinh = Prompt.ShowDialog("Nhập giới tính (nam/nữ/không xác định):", "Thêm mới");
            string chucu = Prompt.ShowDialog("Nhập chức vụ:", "Thêm mới");

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(ngaysinh) || string.IsNullOrEmpty(gioitinh) || string.IsNullOrEmpty(chucu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm dòng mới vào DataGridView
            dataGridView1.Rows.Add(id, hoten, ngaysinh, gioitinh, chucu);

            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void frmtttb_Load(object sender, EventArgs e)
        {

        }
    }
}