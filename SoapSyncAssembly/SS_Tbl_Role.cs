//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapSyncAssembly
{
    using System;
    using System.Collections.Generic;
    
    public partial class SS_Tbl_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SS_Tbl_Role()
        {
            this.SS_Tbl_SiteMap = new HashSet<SS_Tbl_SiteMap>();
            this.SS_Tbl_User = new HashSet<SS_Tbl_User>();
        }
    
        public int Rid { get; set; }
        public string Role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SS_Tbl_SiteMap> SS_Tbl_SiteMap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SS_Tbl_User> SS_Tbl_User { get; set; }
    }
}