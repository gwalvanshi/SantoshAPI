//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GEE.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class CastCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CastCategory()
        {
            this.CandidateDetails = new HashSet<CandidateDetail>();
        }
    
        public int CastCategory_ID { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryDetail { get; set; }
        public Nullable<int> Sessionyear { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_ID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_ID { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<bool> ISDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CandidateDetail> CandidateDetails { get; set; }
    }
}
