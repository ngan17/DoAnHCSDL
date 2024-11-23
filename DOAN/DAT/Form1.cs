using DAT.ThongKeBanHangCuaNV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu();
            thongKeDoanhThu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKeTienNhapHang thongKeTienNhapHang = new ThongKeTienNhapHang();
            thongKeTienNhapHang.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThongKeTienDoanhThuVaNhapHang thongKeTienDoanhThuVaNhapHang = new ThongKeTienDoanhThuVaNhapHang();
            thongKeTienDoanhThuVaNhapHang.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThongKeBanHangCuaNhanVien thongKeBanHangCuaNV = new ThongKeBanHangCuaNhanVien();
            thongKeBanHangCuaNV.ShowDialog();
        }
    }
}
