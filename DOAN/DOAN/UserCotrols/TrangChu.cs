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
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] { "1", "Áo Adidas", "5", "10000000" });
 
            listView1.Items.Add(item);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiBarChart1_Click(object sender, EventArgs e)
        {

        }
    }
}
