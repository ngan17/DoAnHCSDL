using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DAT
{
    public partial class ThongKeTienDoanhThuVaNhapHang : Form
    {
        DBHelper dbHelper = new DBHelper();
        public ThongKeTienDoanhThuVaNhapHang()
        {
            InitializeComponent();
            LoadChartDoanhThuVaNhapHang();
        }

        void LoadChartDoanhThuVaNhapHang()
        {
            int nam = 2023;
            // Lấy dữ liệu Tiền nhập hàng
            SqlParameter sqlParameter1 = new SqlParameter("@Nam", nam);
            DataTable tableNhapHang = dbHelper.ExecuteQuery("LayTongTienNhapHangTheoThang",
                                                            new SqlParameter[] { sqlParameter1 });

            // Lấy dữ liệu Doanh thu
            SqlParameter sqlParameter2 = new SqlParameter("@Nam", nam);
            DataTable tableDoanhThu = dbHelper.ExecuteQuery("LayDoanhThuTheoThang",
                                                            new SqlParameter[] { sqlParameter2 });

            chartDoanhThuVaNhapHang.Series.Clear();

            // Series Tiền nhập hàng
            Series seriesTienNhap = new Series("Tiền nhập hàng");
            seriesTienNhap.ChartType = SeriesChartType.Column; // Đảm bảo là Column
            seriesTienNhap.Color = Color.Blue;

            foreach (DataRow row in tableNhapHang.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                decimal tienNhapHang = Convert.ToDecimal(row["TongTienNhapHang"]);
                seriesTienNhap.Points.AddXY(thang, tienNhapHang);
            }

            // Series Doanh thu
            Series seriesDoanhThu = new Series("Doanh thu");
            seriesDoanhThu.ChartType = SeriesChartType.Column; // Đảm bảo là Column
            seriesDoanhThu.Color = Color.Green;

            foreach (DataRow row in tableDoanhThu.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);
                seriesDoanhThu.Points.AddXY(thang, doanhThu);
            }

            // Thêm Series vào Chart
            chartDoanhThuVaNhapHang.Series.Add(seriesTienNhap);
            chartDoanhThuVaNhapHang.Series.Add(seriesDoanhThu);

            // Cài đặt trục X và Y
            chartDoanhThuVaNhapHang.ChartAreas[0].AxisX.Title = "Tháng";
            chartDoanhThuVaNhapHang.ChartAreas[0].AxisY.Title = "Giá trị (VNĐ)";
            chartDoanhThuVaNhapHang.ChartAreas[0].AxisX.Interval = 1;
            chartDoanhThuVaNhapHang.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";

            // Thêm tiêu đề
            chartDoanhThuVaNhapHang.Titles.Clear();
            chartDoanhThuVaNhapHang.Titles.Add("Biểu đồ tổng hợp tiền nhập hàng và doanh thu theo tháng năm " + nam);
            chartDoanhThuVaNhapHang.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);

            // Đảm bảo các cột không chồng chéo
            chartDoanhThuVaNhapHang.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartDoanhThuVaNhapHang.ChartAreas[0].AxisX.IsMarginVisible = true;

            
        }
    }
}
