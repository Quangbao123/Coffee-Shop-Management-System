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
    public partial class frm_ttk : DevExpress.XtraEditors.XtraForm
    {
        public string AccountID { get; set; }
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }

        public frm_ttk()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("1", "Nguyễn Văn A", "01/01/1990", "Nam", "Quản lý");
            dataGridView1.Rows.Add("2", "Trần Thị B", "15/03/1992", "Nữ", "Nhân viên");
            dataGridView1.Rows.Add("3", "Lê Văn C", "20/05/1988", "Nam", "Pha chế");
            dataGridView1.Rows.Add("4", "Phạm Thị D", "12/07/1995", "Nữ", "Thu ngân");
        }

        private void frm_ttk_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Mở form nhập liệu
            using (var addForm = new frm_ttk())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ form nhập
                    string id = addForm.AccountID;
                    string hoTen = addForm.FullName;
                    string ngaySinh = addForm.BirthDate;
                    string gioiTinh = addForm.Gender;
                    string chucVu = addForm.Position;

                    // Thêm dòng mới vào DataGridView
                    dataGridView1.Rows.Add(id, hoTen, ngaySinh, gioiTinh, chucVu);

                    // Thông báo thành công
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}