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
    
    public partial class SS_Tbl_Settings
    {
        public int Id { get; set; }
        public string HelpMsg { get; set; }
        public string TerminationMsg { get; set; }
        public string SubscriptionMsg { get; set; }
        public Nullable<int> Language { get; set; }
        public string InvalidKeyWordMsg { get; set; }
        public string NoSubscriptionMsg { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string AlreadySubscribed { get; set; }
    
        public virtual SS_Tbl_Language SS_Tbl_Language { get; set; }
    }
}
