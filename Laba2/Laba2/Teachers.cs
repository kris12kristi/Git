//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laba2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teachers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teachers()
        {
            this.Teachers_Subject = new HashSet<Teachers_Subject>();
        }
    
        public int Teachers_id { get; set; }
        public string Teachers_name { get; set; }
        public int Teachers_age { get; set; }
        public string Teachers_level { get; set; }
        public string Teachers_phone { get; set; }
        public int Kaf_Teach_FK { get; set; }
    
        public virtual Kafedra Kafedra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teachers_Subject> Teachers_Subject { get; set; }
    }
}
