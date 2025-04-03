using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace quanLyQuanCaPhe
{
    public partial class frm_xemgia : DevExpress.XtraEditors.XtraForm
    {
        public frm_xemgia()
        {
            InitializeComponent();
        }

        private void frm_xemgia_Load(object sender, EventArgs e)
        {
            // Tạo danh sách các món
            List<string> items = new List<string>
            {
                "Bò húc", "Trà sữa", "Cacao nóng", "Đen đường", "Trà líp tông", "Trà gừng",
                "Coca Cola", "Pepsi", "Aquarius"
            };

            // Thiết lập giá đồng nhất cho tất cả các món
            int price = 15000;

            // Lặp qua danh sách và thêm vào DataGridView
            foreach (var item in items)
            {
                dataGridView1.Rows.Add(item, price);
            }
        }
    }
}
