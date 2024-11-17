using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DOAN.UserCotrols
{
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2();


            var bestseller = ql.ChiTietHoaDons.GroupBy(t => t.MaSanPham).Select(t => new
            {
                ID = t.Key,
                SoLuongBan = t.Sum(ct => ct.SoLuong)
            }).OrderByDescending(t => t.SoLuongBan).Take(7).ToList();

            var chartdata = bestseller.Join(ql.SanPhams, t => t.ID, sp => sp.MaSanPham, (t, sp) => new { sp.TenSanPham, t.SoLuongBan }).ToList();
            chart1.Series.Clear();
            Series series = new Series("Sản phẩm bán chạy");
            series.ChartType = SeriesChartType.Column;

            var doanhthubd = ql.ChiTietHoaDons.GroupBy(t => t.MaSanPham).Select(t => new
            {
                ID = t.Key,
                SoLuongBan = t.Sum(ct => ct.SoLuong)
            }).OrderByDescending(t => t.SoLuongBan).Take(7).ToList();


            foreach (var i in chartdata)
            {
                series.Points.AddXY(i.TenSanPham, i.SoLuongBan);
            }

            series.ChartType = SeriesChartType.Bar;
            chart1.Series.Add(series);
            SoDon.Text = ql.HoaDons.Count(t => t.NgayMuaHang == DateTime.Today).ToString();
            decimal total = ql.HoaDons
      .Where(t => t.NgayMuaHang == DateTime.Today)
      .Sum(t => (decimal?)t.TongTien) ?? 0m; // Nullable cast

            string dt = total.ToString();

            if (dt == null)
            {
                DoanThu.Text = "0 VNĐ";
            }
            else
            {
                DoanThu.Text=dt+" VNĐ";
            }

            comboBox1.Items.Add("Hôm nay");
            comboBox1.Items.Add("Tuần này");
            comboBox1.Items.Add("Tháng này");
            comboBox1.Items.Add("Năm này");
            var doanhThuData = ql.HoaDons
             .Where(hd => hd.NgayMuaHang != null)  // Loại bỏ giá trị ngày tháng trống
             .OrderBy(hd => hd.NgayMuaHang)  // Sắp xếp theo ngày tháng
             .Select(hd => new
             {
                 NgayMuaHang = hd.NgayMuaHang,  // Chỉ lấy ngày mà không có giờ phút giây
                 TongTien = hd.TongTien
             }).ToList();


            // Xóa các series cũ (nếu có)
            chartDoanhThu.Series.Clear();

            // Tạo series cho biểu đồ doanh thu
            Series series1 = new Series("Doanh Thu");
            series1.ChartType = SeriesChartType.Line;  // Biểu đồ đường cho doanh thu
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Double;
            chartDoanhThu.Series.Clear();  // Xóa các series cũ của chartDoanhThu
            chartDoanhThu.Series.Add(series1);

            // Thêm dữ liệu vào series
            foreach (var item in doanhThuData)
            {
                series1.Points.AddXY(item.NgayMuaHang, item.TongTien);
            }

            // Đặt tiêu đề và cấu hình cho biểu đồ doanh thu
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add("Biểu Đồ Doanh Thu Theo Đơn Hàng");
            chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày Mua Hàng";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu (VNĐ)";

  

        }




        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiBarChart1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiSmoothLabel2_Click(object sender, EventArgs e)
        {

        }

        private void SoDon_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            LichLamNhanVien l=new LichLamNhanVien();
            l.Show();
        }
    }
}
