//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSCI540ProjectGroup1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT()
        {
            this.APPOINTMENTs = new HashSet<APPOINTMENT>();
        }
    
        public int IDClient { get; set; }
        public string FnameClient { get; set; }
        public string MnameClient { get; set; }
        public string LnameClient { get; set; }
        public string PhoneClient { get; set; }
        public string CelClient { get; set; }
        public string StreetClient { get; set; }
        public string CountyClient { get; set; }
        public short ZipCodeClient { get; set; }
        public string EmailClient { get; set; }
        public string IDUserClient { get; set; }
        public string StateClient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPOINTMENT> APPOINTMENTs { get; set; }
    }
}
