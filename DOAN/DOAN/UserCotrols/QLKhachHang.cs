using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN.UserCotrols
{
    public partial class QLKhachHang : UserControl
    {

        List <KhachHang> addkh=new List <KhachHang> ();
        List <KhachHang> delete=new List <KhachHang> ();
        List<KhachHang> list = new List<KhachHang>();

        string ma;
        QuanLyCuaHangQuanAoEntities ql=new QuanLyCuaHangQuanAoEntities ();

        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangQuanAoEntities ql = new QuanLyCuaHangQuanAoEntities();
            load_data();
            list=ql.KhachHangs.ToList ();
            load_cbo_gt();
        }

        private string create_manv()
        {


            string mamoi = list
                            .OrderByDescending(t => t.MaKhachHang)
                            .Select(t => t.MaKhachHang)
                            .FirstOrDefault();
            if (mamoi == null)
            {
                return "NV000";
            }
            int x = int.Parse(mamoi.Substring(2));
            x++;
            return $"NV{x:000}";

        }

        private void load_cbo_gt()
        {
            string[] s = new string[] { "Nam", "Nữ" };


            cbo_gt.DataSource = s;
            cbo_gt.SelectedIndex = 0;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ma=row.Cells[0].Value.ToString();
                txt_ten.Text = row.Cells[1].Value.ToString();
                txt_email.Text=row.Cells[2].Value.ToString();
                txt_sdt.Text=row.Cells[3].Value.ToString();
                cbo_gt.SelectedItem=row.Cells[4].Value.ToString();
                dateTimePicker1.Text=row.Cells[5].Value.ToString();
                txt_DiaChi.Text=row.Cells[6].Value.ToString();
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                string ma = (row.Cells["MaKhachHang"].Value.ToString());


                KhachHang i = list.FirstOrDefault(t => t.MaKhachHang == ma);
                list.Remove(i);
                delete.Add(i);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            KhachHang kh=new KhachHang();
            kh.MaKhachHang = create_manv();
            kh.DiaChi=txt_DiaChi.Text;
            kh.Email=txt_email.Text;
            kh.HoTen=txt_ten.Text;
            kh.GioiTinh=cbo_gt.SelectedItem.ToString();
            kh.NgaySinh=DateTime.Parse(dateTimePicker1.Text);
            kh.SoDienThoai=txt_sdt.Text;
            list.Add(kh);
            addkh.Add(kh);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=list;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            KhachHang kh = list.FirstOrDefault(t => t.MaKhachHang == ma);

            kh.DiaChi = txt_DiaChi.Text;
            kh.Email = txt_email.Text;
            kh.HoTen = txt_ten.Text;
            kh.GioiTinh = cbo_gt.SelectedItem.ToString();
            kh.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
            kh.SoDienThoai = txt_sdt.Text;
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            foreach (KhachHang nhanVien in list)
            {
                KhachHang c = ql.KhachHangs.FirstOrDefault(t => t.MaKhachHang == nhanVien.MaKhachHang);
                if (c != null)
                {


                    ql.Entry(c).CurrentValues.SetValues(nhanVien);



                }

            }
            foreach (KhachHang x in addkh)
            {
                ql.KhachHangs.Add(x);
            }
            addkh = new List<KhachHang>();
            foreach (KhachHang x in delete)
            {
                var deletedItem = ql.KhachHangs.FirstOrDefault(t => t.MaKhachHang == x.MaKhachHang);
                ql.KhachHangs.Remove(deletedItem);
            }
            delete = new List<KhachHang>();
            ql.SaveChanges();
            load_data();
        }

        private void load_data()
        {
            dataGridView1.DataSource = ql.KhachHangs.ToList();
        }
    }
}
