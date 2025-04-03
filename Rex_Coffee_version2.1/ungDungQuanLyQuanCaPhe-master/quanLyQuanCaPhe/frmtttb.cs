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
    public partial class frmtttb : DevExpress.XtraEditors.XtraForm
    {
        public frmtttb()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1, "Khu vực A", 4, "Trống");
            dataGridView1.Rows.Add(2, "Khu vực B", 6, "Đang sử dụng");
            dataGridView1.Rows.Add(3, "Khu vực C", 2, "Đã đặt trước");
            dataGridView1.Rows.Add(4, "Khu vực D", 8, "Trống"); 
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
            string idBan = Prompt.ShowDialog("Nhập Id bàn:", "Thêm mới");
            string viTri = Prompt.ShowDialog("Nhập vị trí:", "Thêm mới");
            string soLuongGhe = Prompt.ShowDialog("Nhập số lượng ghế:", "Thêm mới");
            string trangThai = Prompt.ShowDialog("Nhập trạng thái (Trống/Đang sử dụng/Đã đặt trước):", "Thêm mới");

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(idBan) || string.IsNullOrEmpty(viTri) || string.IsNullOrEmpty(soLuongGhe) || string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm dòng mới vào DataGridView
            dataGridView1.Rows.Add(idBan, viTri, soLuongGhe, trangThai);

            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void frmtttb_Load(object sender, EventArgs e)
        {

        }
    }
}