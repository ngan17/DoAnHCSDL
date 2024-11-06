using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class DANGNHAP : Form
    {
        public string username;
        public DANGNHAP()
        {
            InitializeComponent();
        }



        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            QuanLyCuaHangQuanAoEntities ql=new QuanLyCuaHangQuanAoEntities();
            var x = ql.tbl_User.FirstOrDefault(t => t.TaiKhoan == txt_UserName.Text && t.PasswordSalt+t.PasswordHash==txt_PassWord.Text);
            if (x!=null)
            {
                FORMCHINH f = new FORMCHINH(x.TaiKhoan);
                this.Hide();
                f.Show();
            }    
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!", "Đăng nhập thất bại");
                txt_PassWord.Clear();
            }    
      
            
        }

        private void Btn_DangKy_Click(object sender, EventArgs e)
        {
            DANGKY DangKy = new DANGKY();
       
            DangKy.Show();
            this.Hide();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
