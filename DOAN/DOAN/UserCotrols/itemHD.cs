﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN.UserCotrols
{
    public partial class itemHD1 : UserControl
    {
        public float ThanhTien;
        public string NameCTHD;
        public string ColorCt;
        public string SizeCt;
        public decimal gia;
        public int soluong;
        public itemHD1()
        {
            InitializeComponent();
        }

        private void itemHD_Load(object sender, EventArgs e)
        {

        }

        public void getItem(string name,string gia,string anh,int soluong,string size,string color)
        {
            this.lb_name.Text = name;
            this.NameCTHD = name;
            this.ColorCt = color;
            this.SizeCt = size;
            this.soluong = soluong;
            this.gia = decimal.Parse(gia);
            lb_Gia.Text = gia;
            AnhSP.Image = Image.FromFile(anh);
            lb_SL.Text = soluong.ToString();
            SizeSP.Text = size.ToString();
            ColorSP.Text = color.ToString();
            this.ThanhTien= soluong * float.Parse(gia);
            lb_TongTien.Text =( soluong*float.Parse(gia)).ToString();
        }

        private void SoLuong_Click(object sender, EventArgs e)
        {
            
        }
        public event EventHandler Remove;
        private void button1_Click(object sender, EventArgs e)
        {
            Remove?.Invoke(this, EventArgs.Empty);
        }

        private void ColorSP_Click(object sender, EventArgs e)
        {

        }

        private void lb_Gia_Click(object sender, EventArgs e)
        {

        }
    }
    
}
