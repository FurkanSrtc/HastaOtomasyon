//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlinikApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hasta()
        {
            this.Randevu = new HashSet<Randevu>();
        }
    
        public int H_ID { get; set; }
        public string H_AD { get; set; }
        public string H_SOYAD { get; set; }
        public Nullable<System.DateTime> H_DTARIH { get; set; }
        public string H_TC { get; set; }
        public string H_TEL { get; set; }
        public string H_ADRES { get; set; }
        public Nullable<byte> H_CID { get; set; }
        public Nullable<bool> H_DURUM { get; set; }
        public string H_EMAIL { get; set; }
    
        public virtual Cinsiyet Cinsiyet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevu { get; set; }
    }
}
