//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOAN
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuNhap
    {
        public int MaChiTietPhieuNhap { get; set; }
        public Nullable<int> MaPhieuNhap { get; set; }
        public Nullable<int> MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    
        public virtual PhieuNhapHang PhieuNhapHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
