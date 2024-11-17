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

using System.Data.Entity;

namespace DOAN.UserCotrols
{
    public partial class BanHang : UserControl
    {
        public float TongTienHang=0;
        public string TaiKhoan;
    
        public BanHang()
        {
            InitializeComponent();
        }

        private void item3_Load(object sender, EventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            using (     QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2())
            {
                try
                {
                    var loaiSanPham = ql.LoaiSanPhams.Select(l => new { l.MaLoai, l.TenLoai }).Distinct().ToList();
                    var sizeSanPham = ql.SanPhams.Select(s => s.Size).Distinct().ToList();
                    var mauSacSanPham = ql.SanPhams.Select(s => s.MauSac).Distinct().ToList();

                   
                    cbo_Loai.Items.Clear();
                    cbo_Loai.Items.Insert(0, new { MaLoai = 0, TenLoai = "" }); 
                    foreach (var item in loaiSanPham)
                    {
                        cbo_Loai.Items.Add(item); 
                    }
                    cbo_Loai.DisplayMember = "TenLoai"; 
                    cbo_Loai.ValueMember = "MaLoai";

                    cbo_Loai.SelectedIndex = 1;

                 
                    cbo_Mau.Items.Clear();
                    cbo_Mau.Items.Insert(0, ""); 
                    foreach (var color in mauSacSanPham)
                    {
                        cbo_Mau.Items.Add(color);
                    }
                    cbo_Mau.SelectedIndex = 0;

                   
                    cbo_Size.Items.Clear();
                    cbo_Size.Items.Insert(0, ""); 
                    foreach (var size in sizeSanPham)
                    {
                        cbo_Size.Items.Add(size);
                    }
                    cbo_Size.SelectedIndex = 0;

             
                    var sanPhamList = ql.SanPhams.ToList();
                    flowLayoutPanel1.Controls.Clear();
                    foreach (var sp in sanPhamList)
                    {
                        Item item = new Item();
                        item.SetSP(sp.TenSanPham, sp.HinhAnh, sp.Gia.ToString(), sp.Size.ToString(), sp.MauSac.ToString());
                        item.OnAddItemHD += ItemControl_OnAddItemHD;
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo");
                }
            }
        }



        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemHD11_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void ItemControl_OnAddItemHD(object sender, EventArgs e)
        {
           
            itemHD1 newItemHD = new itemHD1();

          
            Item item = sender as Item;
            if (item != null && item.Count>0)
            {
                newItemHD.getItem(item.name, item.price, item.Imagess, item.Count, item.SizeSP1, item.color);
                if (kt(newItemHD))
                {
                    flowLayoutPanel3.Controls.Add(newItemHD);

                    newItemHD.Remove += RemoveItem;
                    TongTienHang += newItemHD.ThanhTien;
                    txt_TongTien.Text = TongTienHang.ToString();
                }    
                
            }
        
           
            
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            itemHD1 itemHD = sender as itemHD1;
            TongTienHang -= itemHD.ThanhTien;
            txt_TongTien.Clear();
            txt_TongTien.Text += TongTienHang.ToString();
            flowLayoutPanel3.Controls.Remove(itemHD );

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private bool kt(itemHD1 itemHD)
        {
            foreach (var con in flowLayoutPanel3.Controls)
            {
                itemHD1 i= con as itemHD1;
                if (i.NameCTHD==itemHD.NameCTHD&&i.SizeCt==itemHD.SizeCt&&i.ColorCt==itemHD.ColorCt)
                return false;
            }
            return true;

            }
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            int maLoai = (int)cbo_Loai.SelectedValue;
            QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2();
            List<SanPham> list = ql.SanPhams.Include(t => t.LoaiSanPham).Where(t => t.LoaiSanPham.TenLoai == cbo_Loai.ValueMember).ToList();


       
            flowLayoutPanel1.Controls.Clear(); 
            foreach (var sp in list)
            {
                Item item = new Item();
                item.SetSP(sp.TenSanPham, sp.HinhAnh, sp.Gia.ToString(), sp.Size.ToString(), sp.MauSac.ToString());
                item.OnAddItemHD += ItemControl_OnAddItemHD; 
                flowLayoutPanel1.Controls.Add(item); 
            }
        }

        private void cbo_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            QuanLyCuaHangQuanAoEntities2 ql=new QuanLyCuaHangQuanAoEntities2();
            HoaDon hd=new HoaDon();
            hd.TrangThaiThanhToan = "Đã thanh toán";
            hd.MaNhanVien=ql.tbl_User.Where(t=>t.TaiKhoan==this.TaiKhoan).Select(t=>t.MaNhanVien).FirstOrDefault();
            hd.MaKhachHang = 1;
            hd.TongTien=decimal.Parse(txt_TongTien.Text);
            hd.NgayMuaHang=DateTime.Now;
            ql.HoaDons.Add(hd);
            ql.SaveChanges();
            ChiTietHoaDon ct=new ChiTietHoaDon();
            ct.MaHoaDon = hd.MaHoaDon;
            foreach (var con in flowLayoutPanel3.Controls)
            {
                itemHD1 i = con as itemHD1;
                ct.MaSanPham=ql.SanPhams.Where(t=>t.TenSanPham==i.NameCTHD).Select(t=>t.MaSanPham).FirstOrDefault();
                ct.DonGia = i.gia;
                ct.SoLuong=i.soluong;
                ct.ChietKhau = 0;
                ct.GiaSauChietKhau=(decimal)(i.ThanhTien);
                ql.ChiTietHoaDons.Add(ct);
                ql.SaveChanges() ;  
            }
            InHoaDon inHoaDon = new InHoaDon();
            inHoaDon.Show();
            inHoaDon.tennv=ql.NhanViens.Where(t=>t.MaNhanVien==hd.MaNhanVien).Select(t=>t.HoTen).First();
            inHoaDon.tenkhach = "Khách vãng lai";
            inHoaDon.tongtien = decimal.Parse(txt_TongTien.Text);
            inHoaDon.tienkhach = decimal.Parse(txt_TienKhach.Text);
            inHoaDon.tienthua=decimal.Parse(txtTienThoi.Text);  
            inHoaDon.ngaylap=DateTime.Now;
            inHoaDon.ShowInvoiceReport(hd.MaHoaDon);
        }

        private void txt_TienKhach_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txt_TienKhach_TextChanged(object sender, EventArgs e)
        {
            if (txt_TienKhach.Text==null) { txtTienThoi.Text = "0";return; }
            long tienthoi=long.Parse(txt_TienKhach.Text)-long.Parse(txt_TongTien.Text);
            if (tienthoi <= 0) txtTienThoi.Text = "0";
            else
                txtTienThoi.Text = tienthoi.ToString();
        }
        
        
    }
}
