//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace speedtrainVives.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBestelling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBestelling()
        {
            this.tblBestellijn = new HashSet<tblBestellijn>();
        }
    
        public int BestellingID { get; set; }
        public string GebruikersID { get; set; }
        public System.DateTime Vertrekdatum { get; set; }
        public System.DateTime Besteldatum { get; set; }
        public byte Geannuleerd { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBestellijn> tblBestellijn { get; set; }
    }
}
