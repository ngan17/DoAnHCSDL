using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN.UserCotrols
{
    public partial class add_SanPham : UserControl
    {
        public add_SanPham()
        {
            InitializeComponent();
        }

        private void add_SanPham_Load(object sender, EventArgs e)
        {
            string sql = $" select TenLoai  from SanPham,LoaiSanPham where SanPham.Maloai=LoaiSanPham.MaLoai ";
            string sql1 = $" select Size  from SanPham ";

            ConnectCSDL connect = new ConnectCSDL();
            try
            {

                DataTable dt2 = ConnectCSDL.GetDataTable(sql1);

                DataTable dt = ConnectCSDL.GetDataTable(sql);


                foreach (DataRow row in dt.Rows)
                {

                    if (!comboBox1.Items.Contains(row[0]))
                        comboBox1.Items.Add(row[0].ToString());


                }
                foreach (DataRow row in dt2.Rows)
                {

                    if (!comboBox2.Items.Contains(row[0]))
                        comboBox2.Items.Add(row[0].ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string sql = $"insert into SanPham(TenSanPham,MaLoai,Size,MauSac,Gia,SoLuong,HinhAnh) values (N)";

            ConnectCSDL.ExecuteNonQuery(sql);
        }
    }
}
