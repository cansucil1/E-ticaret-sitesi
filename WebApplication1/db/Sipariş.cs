//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sipariş
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sipariş()
        {
            this.Sipariş_Detay = new HashSet<Sipariş_Detay>();
        }
    
        public int id { get; set; }
        public string no { get; set; }
        public System.DateTime tarih { get; set; }
        public string durum { get; set; }
        public int üye_id { get; set; }
        public int adres_id { get; set; }
        public System.DateTime alma_tarihi { get; set; }
        public Nullable<System.DateTime> güncelleme_tarihi { get; set; }
        public string açıklama { get; set; }
    
        public virtual Adres Adres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sipariş_Detay> Sipariş_Detay { get; set; }
        public virtual Üye Üye { get; set; }
    }
}
