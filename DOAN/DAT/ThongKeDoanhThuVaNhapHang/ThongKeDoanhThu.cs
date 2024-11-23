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
    public partial class ThongKeDoanhThu : Form
    {
        private DBHelper dbHelper = new DBHelper();
        public ThongKeDoanhThu()
        {
            InitializeComponent();

            loadChartDoanhThuThang();
        }

        void loadChartDoanhThuThang()
        {
            //int namHienTai = DateTime.Now.Year;
            int nam = 2023;
            SqlParameter sqlParameter = new SqlParameter("@Nam", nam);
            DataTable table = dbHelper.ExecuteQuery("LayDoanhThuTheoThang",
                                                new SqlParameter[] { sqlParameter });
            
            chartDoanhThuThang.Series.Clear();

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in table.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);

                series.Points.AddXY(thang, doanhThu);
            }

            chartDoanhThuThang.Series.Add(series);

            chartDoanhThuThang.ChartAreas[0].AxisX.Title = "Tháng";
            chartDoanhThuThang.ChartAreas[0].AxisY.Title = "Doanh thu";
            chartDoanhThuThang.ChartAreas[0].AxisX.Interval = 1;

            chartDoanhThuThang.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";

            chartDoanhThuThang.Titles.Clear();
            chartDoanhThuThang.Titles.Add("Biểu đồ doanh thu theo tháng năm " + nam);
            chartDoanhThuThang.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);


        }


    }
}
