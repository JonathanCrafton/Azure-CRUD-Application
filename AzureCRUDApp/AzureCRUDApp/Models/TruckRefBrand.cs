//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzureCRUDApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TruckRefBrand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TruckRefBrand()
        {
            this.TruckDetails = new HashSet<TruckDetail>();
        }
    
        public int TruckRefBrandID { get; set; }
        public string TruckRefBrandName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TruckDetail> TruckDetails { get; set; }
    }
}
