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
    public partial class ThongKeTienNhapHang : Form
    {
        DBHelper dbHelper = new DBHelper();
        public ThongKeTienNhapHang()
        {
            InitializeComponent();

            loadChartTienNhapHang();
        }

        void loadChartTienNhapHang()
        {
            //int namHienTai = DateTime.Now.Year;
            int nam = 2023;
            SqlParameter sqlParameter = new SqlParameter("@Nam", nam);
            DataTable table = dbHelper.ExecuteQuery("LayTongTienNhapHangTheoThang",
                                                new SqlParameter[] { sqlParameter });

            chartTienNhapHang.Series.Clear();

            Series series = new Series("Tiền nhập hàng");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in table.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                decimal tienNhapHang = Convert.ToDecimal(row["TongTienNhapHang"]);

                series.Points.AddXY(thang, tienNhapHang);
            }

            chartTienNhapHang.Series.Add(series);

            chartTienNhapHang.ChartAreas[0].AxisX.Title = "Tháng";
            chartTienNhapHang.ChartAreas[0].AxisY.Title = "Tiền nhập hàng";
            chartTienNhapHang.ChartAreas[0].AxisX.Interval = 1;

            chartTienNhapHang.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";

            chartTienNhapHang.Titles.Clear();
            chartTienNhapHang.Titles.Add("Biểu đồ tiền nhập hàng theo tháng năm " + nam);
            chartTienNhapHang.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
        }
    }
}
