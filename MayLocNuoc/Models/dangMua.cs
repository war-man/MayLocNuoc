//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MayLocNuoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dangMua
    {
        public int idDM { get; set; }
        public Nullable<int> soluong { get; set; }
        public decimal gia { get; set; }
        public Nullable<int> sophantram { get; set; }
        public Nullable<bool> daxoa { get; set; }
        public Nullable<int> idSP { get; set; }
        public string taikhoan { get; set; }
    
        public virtual acc acc { get; set; }
        public virtual sanpham sanpham { get; set; }
    }
}
