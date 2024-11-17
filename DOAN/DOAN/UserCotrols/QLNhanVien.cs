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
    public partial class QLNhanVien : UserControl
    {
       
        List <NhanVien> list= new List <NhanVien> ();
        QuanLyCuaHangQuanAoEntities2 ql=new QuanLyCuaHangQuanAoEntities2 ();
        int ma;
        List<NhanVien> deleteNV=new List<NhanVien> ();
        List<NhanVien> add_nv=new List<NhanVien> ();
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            list=ql.NhanViens.ToList();
            load_data();
            load_cbo_chuvu();
            load_cbo_gt();
            load_cbo_trangthai();
        }

        private void uiLabel6_Click(object sender, EventArgs e)
        {

        }
        private void load_cbo_gt()
        {
            string[] s = new string[] { "Nam", "Nữ" };


            cbo_GT.DataSource=s;
            cbo_GT.SelectedIndex=0;
        }

        

        private void load_cbo_trangthai()
        {
            QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2();
            string[] s = new string[] { "Đang làm việc", "Đã nghỉ" };
            cbo_TrangThai.Items.AddRange(s);
            cbo_TrangThai.SelectedIndex=0;
        }

        private void load_cbo_chuvu()
        {
            string[] s = new string[] { "Quản lý", "Nhân viên" };

            cbo_Chucvu.Items.AddRange(s);
            cbo_Chucvu.SelectedIndex=0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ma = int.Parse(row.Cells[0].Value.ToString());
                txt_Ten.Text = (row.Cells[1].Value.ToString());
                cbo_GT.SelectedItem = row.Cells[2].Value.ToString();
                txt_Email.Text = (row.Cells[3].Value.ToString());
                txt_diachi.Text = (row.Cells[4].Value.ToString());
                txt_SDT.Text = (row.Cells[5].Value.ToString());
                cbo_Chucvu.SelectedItem = row.Cells[6].Value.ToString();
                dateTimePicker1.Text = (row.Cells[7].Value.ToString());
                txtLuong.Text = (row.Cells[9].Value.ToString());
                cbo_TrangThai.SelectedItem=row.Cells[8].Value.ToString();
               
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            NhanVien x1=new NhanVien();
            x1.HoTen = txt_Ten.Text;
        
            x1.GioiTinh = cbo_GT.SelectedItem.ToString();
            x1.Email = txt_Email.Text;
            x1.DiaChi = txt_diachi.Text;
            x1.SoDienThoai=txt_SDT.Text;
            x1.ChucVu=cbo_Chucvu.SelectedItem.ToString();
            x1.NgayVaoLam =DateTime.Parse( dateTimePicker1.Text);
            x1.Luong=decimal.Parse( txtLuong.Text);
            x1.TrangThaiLamViec=cbo_TrangThai.SelectedItem.ToString();

         
            list.Add(x1);
            add_nv.Add(x1);
            x1=new NhanVien();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=list;

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                int ma = int.Parse(row.Cells["MaNhanVien"].Value.ToString());


                NhanVien i = list.FirstOrDefault(t => t.MaNhanVien == ma);


                if (i != null)
                {
                    list.Remove(i);
                    deleteNV.Add(i);
                }
            }
            dataGridView1.DataSource=null;
            dataGridView1.DataSource=list;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            NhanVien x=list.FirstOrDefault(t=>t.MaNhanVien==ma);
            x.HoTen = txt_Ten.Text;
            x.GioiTinh = cbo_GT.SelectedItem.ToString();
            x.Email = txt_Email.Text;
            x.DiaChi = txt_diachi.Text;
            x.SoDienThoai = txt_SDT.Text;
            x.ChucVu = cbo_Chucvu.SelectedItem.ToString();
            x.NgayVaoLam = DateTime.Parse(dateTimePicker1.Text);
            x.Luong = decimal.Parse(txtLuong.Text);
            x.TrangThaiLamViec = cbo_TrangThai.SelectedItem.ToString();
            dataGridView1 .DataSource = null;
            dataGridView1.DataSource=list;
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            foreach(NhanVien nhanVien in list)
            {
                NhanVien c = ql.NhanViens.FirstOrDefault(t => t.MaNhanVien == nhanVien.MaNhanVien);
                if (c != null)
                {
                  
                    
                        ql.Entry(c).CurrentValues.SetValues(nhanVien);
                        
                    
                    
                }
                
            }
            foreach (NhanVien x in add_nv)
            {
                ql.NhanViens.Add(x);
            }    
            add_nv = new List<NhanVien>();
            foreach(NhanVien x in deleteNV)
            {
                var deletedItem = ql.NhanViens.FirstOrDefault(t => t.MaNhanVien == x.MaNhanVien);
                ql.NhanViens.Remove(deletedItem);
            }    
            deleteNV=new List<NhanVien>();
            ql.SaveChanges();
            load_data();
        }

        private void load_data()
        {
            QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2();
            dataGridView1.DataSource = ql.NhanViens.ToList();
            

            list = ql.NhanViens.ToList();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
