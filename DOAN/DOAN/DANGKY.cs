using DOAN.UserCotrols;
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
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            InitializeComponent();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
          

        }

        private void uiTextBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool kt()
        {
            QuanLyCuaHangQuanAoEntities ql=new QuanLyCuaHangQuanAoEntities();
            var x = ql.tbl_User.FirstOrDefault(t => t.TaiKhoan == txt_username.Text);
            if (x != null) 
            {
                MessageBox.Show("Tên tài khoản đã tồn tại trong hệ thống vui lòng đặt tên tài khoản khác!!","Lỗi");
                return false; 
            }
            if (txt_email.Text.Length==0||txt_pass.Text.Length==0||txt_repass.Text.Length==0||txt_sdt.Text.Length==0||txt_username.Text.Length==0||!(chk_Nam.Checked||chk_Nu.Checked))
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin!!", "Lỗi");
                return false;
            }    
            if ( txt_pass.Text.Length < 8 || txt_username.Text.Length < 5)
            {

                MessageBox.Show("(Tên tài khoản dài hơn 4 kí tự, mật khẩu từ 8 ký tự trở lên", "Lỗi");
                return false;
            }
            else if(txt_pass.Text != txt_repass.Text )
            {

                MessageBox.Show("Mật khẩu và Nhập lại mật khẩu không khớp!!", "Lỗi");
                return false;
            }
            return true;

        }

        private string create_manv()
        {
            QuanLyCuaHangQuanAoEntities ql=new QuanLyCuaHangQuanAoEntities();
            
            string mamoi = ql.NhanViens
                            .OrderByDescending(t => t.MaNhanVien)
                            .Select(t => t.MaNhanVien)
                            .FirstOrDefault();
            if (mamoi==null)
            {
                return "NV000";
            }
            int x =int.Parse( mamoi.Substring(2));
            x++;
            return $"NV{x:000}";

        }
        private void Btn_DangKy_Click(object sender, EventArgs e)
        {
            if (kt())
            try
            {
                QuanLyCuaHangQuanAoEntities ql = new QuanLyCuaHangQuanAoEntities();

               
                string maNhanVien = create_manv();
                string gt;
                if (chk_Nam.Checked)
                {
                    gt = "Nam";
                    chk_Nu.Checked = false;
                }
                else
                {
                    gt = "Nữ";
                    chk_Nam.Checked = false;
                }
                
                    NhanVien nv = new NhanVien
                    {
                        HoTen = "",
                        MaNhanVien = maNhanVien,
                        ChucVu = "Nhân viên",
                        NgayVaoLam = DateTime.Now,  
                        Email = txt_email.Text,
                        SoDienThoai = txt_sdt.Text,
                        GioiTinh = gt
                    };
                ql.NhanViens.Add(nv);

               
                tbl_User x = new tbl_User
                {
                    TaiKhoan = txt_username.Text,
                    PasswordHash = txt_pass.Text.Substring( 4),
                    PasswordSalt = txt_pass.Text.Substring(0,4),
                    MaNhanVien = maNhanVien,  
                    Status = "Not Active"
                };
                ql.tbl_User.Add(x);

                ql.SaveChanges();
                    MessageBox.Show("Bạn đã đăng ký thành công! Vui lòng chờ quản lý Active tài khoản để đăng nhập!");
            }

            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors) 
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            else
            {
                txt_username.Clear();
                txt_pass.Clear();
                txt_repass.Clear();
                txt_email.Clear();
                txt_sdt.Clear();
                chk_Nam.Checked = false;
                chk_Nu.Checked = false;
                return;
            }

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            DANGNHAP fdn= new DANGNHAP();
            fdn.Show();
            this.Hide();
        }

        private void uiLabel6_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiSmoothLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
