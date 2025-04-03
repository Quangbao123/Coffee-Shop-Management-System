using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class frm_xemdoanhthu : DevExpress.XtraEditors.XtraForm
    {
        public frm_xemdoanhthu()
        {
            InitializeComponent();
        }

        private void frm_xemdoanhthu_Load(object sender, EventArgs e)
        {
            // Ví dụ về dữ liệu ban đầu, có thể thay thế bằng dữ liệu từ cơ sở dữ liệu
            // Các món ăn cố định với giá đồng nhất là 15000
            var itemList = new List<Item>
            {
                new Item { Id = 1, Name = "Bò húc", Price = 15000 },
                new Item { Id = 2, Name = "Trà sữa", Price = 15000 },
                new Item { Id = 3, Name = "Cacao nóng", Price = 15000 },
                new Item { Id = 4, Name = "Đen đường", Price = 15000 },
                new Item { Id = 5, Name = "Trà líp tông", Price = 15000 },
                new Item { Id = 6, Name = "Trà gừng", Price = 15000 },
                new Item { Id = 7, Name = "Coca Cola", Price = 15000 },
                new Item { Id = 8, Name = "Pepsi", Price = 15000 },
                new Item { Id = 9, Name = "Aquarius", Price = 15000 },
            };

            // Lưu danh sách món ăn vào biến toàn cục
            this.itemList = itemList;
        }

        // Biến lưu trữ dữ liệu món ăn
        private List<Item> itemList;

        // Class đại diện cho món ăn
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lọc theo thời gian nhập vào từ textBox1
            var dateInput = textBox1.Text;
            DateTime startDate;

            // Kiểm tra xem người dùng có nhập ngày tháng hay không
            if (DateTime.TryParse(dateInput, out startDate))
            {
                // Nếu nhập ngày cụ thể, hiển thị các món ăn với số lượng tùy chỉnh
                var filteredSales = GenerateSalesData(startDate);
                DisplayData(filteredSales);
            }
            else if (dateInput.Length == 7 && dateInput.Contains("/"))
            {
                // Nếu người dùng nhập tháng/năm, lọc theo tháng/năm
                var parts = dateInput.Split('/');
                if (parts.Length == 2 && int.TryParse(parts[0], out int month) && int.TryParse(parts[1], out int year))
                {
                    var filteredSales = GenerateSalesDataForMonth(month, year);
                    DisplayData(filteredSales);
                }
            }
            else if (dateInput.Length == 4)
            {
                // Nếu người dùng nhập năm, lọc theo năm
                if (int.TryParse(dateInput, out int year))
                {
                    var filteredSales = GenerateSalesDataForYear(year);
                    DisplayData(filteredSales);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mốc thời gian hợp lệ (ngày/tháng/năm).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm tạo dữ liệu bán hàng cho ngày cụ thể (giả lập số lượng)
        private List<Sale> GenerateSalesData(DateTime date)
        {
            var random = new Random();
            return itemList.Select(item => new Sale
            {
                Id = item.Id,
                Item = item.Name,
                Quantity = random.Next(1, 10), // Số lượng bán ngẫu nhiên từ 1 đến 10
                Price = item.Price,
                Date = date
            }).ToList();
        }

        // Hàm tạo dữ liệu bán hàng cho tháng/năm cụ thể
        private List<Sale> GenerateSalesDataForMonth(int month, int year)
        {
            var random = new Random();
            var daysInMonth = DateTime.DaysInMonth(year, month);
            var sales = new List<Sale>();

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime date = new DateTime(year, month, day);
                sales.AddRange(itemList.Select(item => new Sale
                {
                    Id = item.Id,
                    Item = item.Name,
                    Quantity = random.Next(1, 10), // Số lượng bán ngẫu nhiên từ 1 đến 10
                    Price = item.Price,
                    Date = date
                }));
            }

            return sales;
        }

        // Hàm tạo dữ liệu bán hàng cho năm cụ thể
        private List<Sale> GenerateSalesDataForYear(int year)
        {
            var random = new Random();
            var sales = new List<Sale>();

            for (int month = 1; month <= 12; month++)
            {
                var daysInMonth = DateTime.DaysInMonth(year, month);
                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime date = new DateTime(year, month, day);
                    sales.AddRange(itemList.Select(item => new Sale
                    {
                        Id = item.Id,
                        Item = item.Name,
                        Quantity = random.Next(1, 10), // Số lượng bán ngẫu nhiên từ 1 đến 10
                        Price = item.Price,
                        Date = date
                    }));
                }
            }

            return sales;
        }

        // Hàm hiển thị dữ liệu vào DataGridView và tính tổng doanh thu
        private void DisplayData(List<Sale> filteredSales)
        {
            // Hiển thị dữ liệu vào DataGridView
            dataGridView1.Rows.Clear();
            foreach (var sale in filteredSales)
            {
                dataGridView1.Rows.Add(sale.Id, sale.Item, sale.Quantity, sale.Price);
            }

            // Tính tổng doanh thu
            int totalRevenue = filteredSales.Sum(s => s.Quantity * s.Price);
            textBox2.Text = totalRevenue.ToString("N0");
        }

        // Class đại diện cho giao dịch bán hàng
        public class Sale
        {
            public int Id { get; set; }
            public string Item { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
