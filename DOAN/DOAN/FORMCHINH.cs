﻿using DOAN.UserCotrols;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class FORMCHINH : Form
    {

        private Timer loginTimer;
        private int timeElapsed; // Thời gian đã trôi qua (giây)
        public string username;
        public Point point;
        public FORMCHINH(string username1)
        {
            this.username = username1;
            InitializeComponent();
            InitializeLoginTimer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void groupBox2_Load(object sender, EventArgs e)
        {
         
            
        }

        private void FORMCHINH_Load(object sender, EventArgs e)
        {
            DANGNHAP dn=new DANGNHAP();
            QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2();
            int manv = ql.tbl_User.Where(t => t.TaiKhoan==this.username).Select(t=>t.MaNhanVien).FirstOrDefault();
            TenNV.Text=ql.NhanViens.Where(t=>t.MaNhanVien==manv).Select(t=>t.HoTen).FirstOrDefault();
            ChucVu.Text=ql.NhanViens.Where(t=>t.MaNhanVien==manv).Select(t=>t.ChucVu).FirstOrDefault();
            GioiTinh.Text = ql.NhanViens.Where(t => t.MaNhanVien == manv).Select(t => t.GioiTinh).FirstOrDefault();
            DiaChi.Text=ql.NhanViens.Where(t=>t.MaNhanVien==manv).Select(t=>t.DiaChi).FirstOrDefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddUserControl(UserControl userControl)
        {
           PanelContainer.Controls.Clear();
           PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu tc=new TrangChu();
            AddUserControl(tc);
        }

        private void PanelContaninner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void lb_username_Click(object sender, EventArgs e)
        {

        }

        private void lb_username_Click_1(object sender, EventArgs e)
        {

        }


   

        // Khởi tạo Timer
        private void InitializeLoginTimer()
        {
            timeElapsed = 0; // Bắt đầu từ 0 giây
            loginTimer = new Timer();
            loginTimer.Interval = 1000; // Mỗi 1 giây
            loginTimer.Tick += LoginTimer_Tick;
            loginTimer.Start(); // Bắt đầu bộ đếm thời gian
        }

        // Xử lý sự kiện mỗi lần Timer tick (1 giây trôi qua)
        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed++; // Tăng số giây đã trôi qua

            // Cập nhật giao diện hiển thị thời gian
            int hours = timeElapsed / 3600;
            int minutes = (timeElapsed % 3600) / 60;
            int seconds = timeElapsed % 60;

            // Cập nhật giao diện hiển thị thời gian
            lb_time.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
         }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_time_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void FORMCHINH_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
             
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiSmoothLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            QuanLyKho quanLyKho = new QuanLyKho();
            AddUserControl(quanLyKho);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            AddUserControl(taiKhoan);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            QLHoaDon hoaDon = new QLHoaDon();
            AddUserControl(hoaDon);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            QLKhachHang qLKhachHang = new QLKhachHang();
            AddUserControl(qLKhachHang);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            QLNhanVien taiKhoan = new QLNhanVien();
            AddUserControl(taiKhoan);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            banHang.TaiKhoan=this.username;
            AddUserControl(banHang);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            AddUserControl(tc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse = Control.MousePosition;
                mouse.Offset(-point.X, -point.Y);
                Location = mouse;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
