//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajaDBFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Področja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Področja()
        {
            this.DijakPodročje = new HashSet<DijakPodročje>();
            this.Izvedba = new HashSet<Izvedba>();
            this.PlanDejavnosti = new HashSet<PlanDejavnosti>();
        }
    
        public int PodID { get; set; }
        public string PodIme { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DijakPodročje> DijakPodročje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Izvedba> Izvedba { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanDejavnosti> PlanDejavnosti { get; set; }
    }
}
