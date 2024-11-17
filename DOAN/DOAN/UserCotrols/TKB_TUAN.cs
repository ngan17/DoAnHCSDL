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
    public partial class TKB_TUAN : UserControl
    {
        QuanLyCuaHangQuanAoEntities2 QL=new QuanLyCuaHangQuanAoEntities2 ();
        public TKB_TUAN()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TKB_TUAN_Load(object sender, EventArgs e)
        {
            List<NhanVien> list=QL.NhanViens.ToList();
            CBO_SCN.DataSource = list.Select(t => t.HoTen).ToList();

        }
    }
}
