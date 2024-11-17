using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DOAN
{
    public partial class InHD1 : Form
    {
        public InHD1()
        {
            InitializeComponent();
            this.reportViewer1.RefreshReport();
        }

        private void InHD1_Load(object sender, EventArgs e)
        {

        }

        public void ShowInvoiceReport(int maHoaDon)
        {
            using (QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2())
            {
                // Lấy dữ liệu hóa đơn
                var hoaDonData = ql.HoaDons
                    .Where(hd => hd.MaHoaDon == maHoaDon)
                    .Select(hd => new
                    {
                        MaHoaDon = hd.MaHoaDon,
                        NgayMuaHang = hd.NgayMuaHang,
                        TongTien = hd.TongTien,
                        TrangThaiThanhToan = hd.TrangThaiThanhToan,
                        // Các trường khác nếu cần
                    }).ToList();

                // Lấy dữ liệu chi tiết hóa đơn
                var chiTietData = ql.ChiTietHoaDons
                    .Where(ct => ct.MaHoaDon == maHoaDon)
                    .Select(ct => new
                    {
                        MaSanPham = ct.MaSanPham,
                        TenSanPham = ct.SanPham.TenSanPham,
                        SoLuong = ct.SoLuong,
                        DonGia = ct.DonGia,
                        ThanhTien = ct.SoLuong * ct.DonGia
                    }).ToList();

                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";

                // Xóa các dữ liệu cũ trong báo cáo
                reportViewer1.LocalReport.DataSources.Clear();

                // Tạo và thêm các nguồn dữ liệu vào báo cáo
                ReportDataSource rdsHoaDon = new ReportDataSource("HoaDonDataSet", hoaDonData);
                ReportDataSource rdsChiTietHoaDon = new ReportDataSource("DataSet2", chiTietData);

                reportViewer1.LocalReport.DataSources.Add(rdsHoaDon);
                reportViewer1.LocalReport.DataSources.Add(rdsChiTietHoaDon);

                // Làm mới và hiển thị báo cáo
                reportViewer1.RefreshReport();
            }
        }
    }
}
