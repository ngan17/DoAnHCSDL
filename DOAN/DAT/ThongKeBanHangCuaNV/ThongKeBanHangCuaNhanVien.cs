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

namespace DAT.ThongKeBanHangCuaNV
{
    public partial class ThongKeBanHangCuaNhanVien : Form
    {
        DBHelper dbHelper = new DBHelper();
        public ThongKeBanHangCuaNhanVien()
        {
            InitializeComponent();

            LoadChartBanHang();
        }

        void LoadChartBanHang()
        {
            //thang, nam hien tai
            int nam = 2023;
            int thang = 9;

            SqlParameter[] parameters;
            parameters = new SqlParameter[]
            {
                new SqlParameter("@Nam", nam),
                new SqlParameter("@Thang", thang)
            };

            DataTable table = new DataTable();
            table = dbHelper.ExecuteQuery("ThongKeDoanhSoBanHangCuaNhanVien", parameters);

            chartBanHangCuaNV.Series.Clear();

            Series series = new Series("Số tiền bán hàng");
            series.ChartType = SeriesChartType.Column; // Kiểu biểu đồ cột
            series.Color = Color.Orange;

            // Thêm dữ liệu vào series
            foreach (DataRow row in table.Rows)
            {
                string tenNhanVien = row["HoTen"].ToString();
                decimal tongTienBanHang = Convert.ToDecimal(row["TongTienBanHang"]);

                series.Points.AddXY(tenNhanVien, tongTienBanHang);
            }

            series.IsVisibleInLegend = false;

            chartBanHangCuaNV.Series.Add(series);

            // Thiết lập biểu đồ
            chartBanHangCuaNV.ChartAreas[0].AxisX.Title = "Nhân viên";
            chartBanHangCuaNV.ChartAreas[0].AxisY.Title = "Tổng tiền bán hàng";
            chartBanHangCuaNV.ChartAreas[0].AxisX.Interval = 1;
            chartBanHangCuaNV.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";

            chartBanHangCuaNV.Titles.Add($"Thống kê tổng tiền bán hàng của nhân viên - Tháng {thang} Năm {nam}");

            chartBanHangCuaNV.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
        }
    }
}
