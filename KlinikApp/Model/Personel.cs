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
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.Randevu = new HashSet<Randevu>();
        }
    
        public int P_ID { get; set; }
        public string P_AD { get; set; }
        public string P_SOYAD { get; set; }
        public Nullable<System.DateTime> P_DTARIH { get; set; }
        public string P_TC { get; set; }
        public string P_TEL { get; set; }
        public string P_ADRES { get; set; }
        public string P_EMAIL { get; set; }
        public string P_SIFRE { get; set; }
        public Nullable<byte> P_CID { get; set; }
    
        public virtual Cinsiyet Cinsiyet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevu { get; set; }
    }
}
