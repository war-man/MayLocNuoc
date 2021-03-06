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
    
    public partial class sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sanpham()
        {
            this.daMuas = new HashSet<daMua>();
            this.dangMuas = new HashSet<dangMua>();
            this.danhgias = new HashSet<danhgia>();
            this.giohangs = new HashSet<giohang>();
            this.gioithieux = new HashSet<gioithieu>();
        }
    
        public int idSP { get; set; }
        public string tensp { get; set; }
        public string anhsanpham1 { get; set; }
        public string anhsanpham2 { get; set; }
        public string anhsanpham3 { get; set; }
        public string anhsanpham4 { get; set; }
        public string anhsanpham5 { get; set; }
        public decimal rong { get; set; }
        public decimal dai { get; set; }
        public decimal cao { get; set; }
        public decimal gia { get; set; }
        public string magiamgia { get; set; }
        public Nullable<int> sophantram { get; set; }
        public int soluong { get; set; }
        public string thuongHieu { get; set; }
        public string tieude { get; set; }
        public string chatluong { get; set; }
        public int soLoiLoc { get; set; }
        public string congxuat { get; set; }
        public string tocdoloc { get; set; }
        public string congnghekhangkhuan { get; set; }
        public string congXuatBom { get; set; }
        public string noisanxuat { get; set; }
        public Nullable<bool> daxoa { get; set; }
        public Nullable<bool> hethang { get; set; }
        public Nullable<int> idIfncc { get; set; }
        public Nullable<int> soluongdaban { get; set; }
        public Nullable<System.DateTime> ngaythem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<daMua> daMuas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dangMua> dangMuas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<danhgia> danhgias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<giohang> giohangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gioithieu> gioithieux { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
