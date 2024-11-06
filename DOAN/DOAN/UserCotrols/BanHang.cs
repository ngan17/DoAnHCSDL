using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DOAN.UserCotrols
{
    public partial class BanHang : UserControl
    {
        public float TongTienHang=0;
        public BanHang()
        {
            InitializeComponent();
        }

        private void item3_Load(object sender, EventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            using (QuanLyCuaHangQuanAoEntities ql = new QuanLyCuaHangQuanAoEntities())
            {
                try
                {
                    // Retrieve the list of product categories with their IDs and names
                    var loaiSanPham = ql.LoaiSanPhams.Select(l => new { l.MaLoai, l.TenLoai }).Distinct().ToList();
                    var sizeSanPham = ql.SanPhams.Select(s => s.Size).Distinct().ToList();
                    var mauSacSanPham = ql.SanPhams.Select(s => s.MauSac).Distinct().ToList();

                    // Setup cbo_Loai ComboBox
                    cbo_Loai.Items.Clear();
                    cbo_Loai.Items.Insert(0, new { MaLoai = 0, TenLoai = "" }); // Empty item at the top for "All" option
                    foreach (var item in loaiSanPham)
                    {
                        cbo_Loai.Items.Add(item); // Add each category with both MaLoai and TenLoai
                    }
                    cbo_Loai.DisplayMember = "TenLoai"; 
                    cbo_Loai.ValueMember = "MaLoai";

                    cbo_Loai.SelectedIndex = 1;

                    // Setup cbo_Mau ComboBox for color
                    cbo_Mau.Items.Clear();
                    cbo_Mau.Items.Insert(0, ""); // Add empty item at the start
                    foreach (var color in mauSacSanPham)
                    {
                        cbo_Mau.Items.Add(color);
                    }
                    cbo_Mau.SelectedIndex = 0;

                    // Setup cbo_Size ComboBox for size
                    cbo_Size.Items.Clear();
                    cbo_Size.Items.Insert(0, ""); // Add empty item at the start
                    foreach (var size in sizeSanPham)
                    {
                        cbo_Size.Items.Add(size);
                    }
                    cbo_Size.SelectedIndex = 0;

                    // Load product data into FlowLayoutPanel
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
            QuanLyCuaHangQuanAoEntities ql = new QuanLyCuaHangQuanAoEntities();
            List<SanPham> list = ql.SanPhams.Include(t => t.LoaiSanPham).Where(t => t.LoaiSanPham.TenLoai == cbo_Loai.ValueMember).ToList();


            // Duyệt qua từng sản phẩm và tạo UserControl
            flowLayoutPanel1.Controls.Clear(); // Xóa các điều khiển hiện có
            foreach (var sp in list)
            {
                Item item = new Item();
                item.SetSP(sp.TenSanPham, sp.HinhAnh, sp.Gia.ToString(), sp.Size.ToString(), sp.MauSac.ToString());
                item.OnAddItemHD += ItemControl_OnAddItemHD; // Đăng ký sự kiện
                flowLayoutPanel1.Controls.Add(item); // Thêm điều khiển vào FlowLayoutPanel
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
