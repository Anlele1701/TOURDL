//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TOURDL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.SPTOURs = new HashSet<SPTOUR>();
        }
    
        public int ID_NV { get; set; }
        public string HoTen_NV { get; set; }
        public string GioiTinh_NV { get; set; }
        public Nullable<System.DateTime> NgaySinh_NV { get; set; }
        public string MatKhau { get; set; }
        public string Mail_NV { get; set; }
        public string ChucVu { get; set; }
        public string SDT_NV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPTOUR> SPTOURs { get; set; }
    }
}
