//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coding_Tech.Models.CTDbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBuilding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBuilding()
        {
            this.tblFloors = new HashSet<tblFloor>();
        }
    
        public int id { get; set; }
        public string Description { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> Country { get; set; }
        public string Address { get; set; }
    
        public virtual tblCity tblCity { get; set; }
        public virtual tblCountry tblCountry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFloor> tblFloors { get; set; }
    }
}
