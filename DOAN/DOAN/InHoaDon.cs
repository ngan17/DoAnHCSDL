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
    public partial class InHoaDon : Form
    {
        public decimal tongtien;
        public decimal tienkhach;
        public decimal tienthua;
        public string tenkhach;
        public string tennv;
        public DateTime ngaylap;
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
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
                        MaHoaDon = ct.MaHoaDon,
                        MaSanPham = ct.MaSanPham,
                        Size=ct.SanPham.Size,
                        
                        TenSanPham = ct.SanPham.TenSanPham,
                        MauSac=ct.SanPham.MauSac,
                        SoLuong = ct.SoLuong,
                        DonGia = ct.DonGia,
                        ThanhTien = ct.SoLuong * ct.DonGia
                    }).ToList();

                reportViewer1.LocalReport.ReportPath = "Report2.rdlc"; // Đảm bảo đường dẫn đúng

                // Xóa các dữ liệu cũ trong báo cáo
                reportViewer1.LocalReport.DataSources.Clear();

                // Khai báo các tham số
                var reportParameters = new List<Microsoft.Reporting.WinForms.ReportParameter>
        {
            new ReportParameter("TongTien", tongtien.ToString()),
            new ReportParameter("TienKhach",tienkhach.ToString()), 
            new ReportParameter("TienTra", tienthua.ToString()), 
          new ReportParameter("TenKhach", tenkhach), 
           new ReportParameter("TenNhanVien", tennv), 
           new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")),
           new ReportParameter("MaHoaDon", maHoaDon.ToString())
        };

                // Gán các tham số cho báo cáo
                reportViewer1.LocalReport.SetParameters(reportParameters);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("MaHoaDon", typeof(int));
                dataTable.Columns.Add("MaSanPham", typeof(int));
                dataTable.Columns.Add("TenSanPham", typeof(string));
                dataTable.Columns.Add("SoLuong", typeof(int));
                dataTable.Columns.Add("DonGia", typeof(decimal));
                dataTable.Columns.Add("ThanhTien", typeof(decimal));

                foreach (var item in chiTietData)
                {
                    dataTable.Rows.Add(item.MaHoaDon, item.MaSanPham, item.TenSanPham, item.SoLuong, item.DonGia, item.ThanhTien);
                }
                // Tạo và thêm các nguồn dữ liệu vào báo cáo
                ReportDataSource rdsHoaDon = new ReportDataSource("HoaDonDataSet", hoaDonData);
                ReportDataSource rdsChiTietHoaDon = new ReportDataSource("DataSet2", chiTietData);
               

                reportViewer1.LocalReport.DataSources.Add(rdsHoaDon);
                reportViewer1.LocalReport.DataSources.Add(rdsChiTietHoaDon);

                // Làm mới và hiển thị báo cáo
                reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
