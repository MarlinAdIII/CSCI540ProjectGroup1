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
    
    public partial class JOBCONSUMPTION
    {
        public int IDJobConsump { get; set; }
        public int IDJobDone { get; set; }
        public int IDHair { get; set; }
        public byte QttyPacks { get; set; }
    
        public virtual HAIR HAIR { get; set; }
        public virtual JOBDONE JOBDONE { get; set; }
    }
}
