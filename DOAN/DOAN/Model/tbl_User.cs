//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOAN.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_User
    {
        public string TaiKhoan { get; set; }
        public string MaNhanVien { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Nullable<int> Quyen { get; set; }
        public string Status { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
