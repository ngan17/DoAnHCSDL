using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace DOAN.UserCotrols
{
    public partial class TaiKhoan : UserControl
    {

        List<tbl_User> list = new List<tbl_User>();
        QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2();
        string ma;
        List<tbl_User> delete_tk = new List<tbl_User>();
        List<tbl_User> add_nv = new List<tbl_User>();
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            load_cbo_role();
            load_cbo_tt();
            list=ql.tbl_User.ToList();
            load_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void load_cbo_tt()
        {
            string[] s = new string[] { "Active", "Not Active" };
            cbo_tt.DataSource = s;
        }
        private void load_cbo_role()
        {
            string[] s = new string[] { "1", "2" };
            cbo_role.DataSource = s;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
                txt_tenTK.Text = (row.Cells[0].Value.ToString());
                txt_MatKhau.Text = row.Cells[3].Value.ToString();
                txtMa.Text = (row.Cells[1].Value.ToString());
                txt_hash.Text=row.Cells[2].Value.ToString();
                cbo_role.SelectedItem = row.Cells[4].Value.ToString();
                cbo_tt.SelectedItem=row.Cells[5].Value.ToString();

            }

           

        }
        private void load_data()
        {
            QuanLyCuaHangQuanAoEntities2 ql = new QuanLyCuaHangQuanAoEntities2();
            var TK = ql.tbl_User.ToList();
            dataGridView1.DataSource = TK;
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            tbl_User x=new tbl_User();
            x.TaiKhoan = txt_tenTK.Text;
            x.PasswordHash=txt_hash.Text;
            x.PasswordSalt=txt_MatKhau.Text;
            x.Status=cbo_tt.SelectedItem.ToString();
            x.Quyen=int.Parse(cbo_role.SelectedItem.ToString());
            x.MaNhanVien=int.Parse(txtMa.Text);
            list.Add(x);
            add_nv.Add(x);
            dataGridView1.DataSource=null;
            dataGridView1.DataSource=list;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            tbl_User x = list.FirstOrDefault(t=>t.TaiKhoan==txt_tenTK.Text);
           

            x.PasswordHash = txt_hash.Text;
            x.PasswordSalt = txt_MatKhau.Text;
            x.Status = cbo_tt.SelectedItem.ToString();
            x.Quyen = int.Parse(cbo_role.SelectedItem.ToString());
            x.MaNhanVien = int.Parse(txtMa.Text);
            dataGridView1.DataSource=null;
            dataGridView1.DataSource=list;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dataGridView1.SelectedRows)
            {
                string tk = (x.Cells["TaiKhoan"].Value.ToString());
                tbl_User us = list.Find(t => t.TaiKhoan == tk);
                list.Remove(us);
                delete_tk.Add(us);
            }    
            dataGridView1.DataSource = null;    
            dataGridView1.DataSource=list;  
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            foreach (tbl_User nhanVien in list)
            {
                tbl_User c = ql.tbl_User.FirstOrDefault(t => t.TaiKhoan == nhanVien.TaiKhoan);
                if (c != null)
                {


                    ql.Entry(c).CurrentValues.SetValues(nhanVien);



                }

            }
            foreach (tbl_User x in add_nv)
            {
                ql.tbl_User.Add(x);
            }
            add_nv = new List<tbl_User>();
            foreach (tbl_User x in delete_tk)
            {
                var deletedItem = ql.tbl_User.FirstOrDefault(t => t.TaiKhoan == x.TaiKhoan);
                ql.tbl_User.Remove(deletedItem);
            }
            delete_tk = new List<tbl_User>();
            ql.SaveChanges();
            load_data();
        }
    }
}
