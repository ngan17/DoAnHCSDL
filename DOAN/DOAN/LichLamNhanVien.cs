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
    public partial class LichLamNhanVien : Form
    {
        public LichLamNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddUserControl(UserControl userControl)
        {
            PANEL_CONTANNER.Controls.Clear();
            PANEL_CONTANNER.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void LichLamNhanVien_Load(object sender, EventArgs e)
        {
            TKB_TUAN tKB_TUAN = new TKB_TUAN();
            AddUserControl(tKB_TUAN );
        }
    }
}
