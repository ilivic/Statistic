//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Statistic.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class OBJ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBJ()
        {
            this.Meters = new HashSet<Meters>();
            this.PeriodsRead = new HashSet<PeriodsRead>();
        }
    
        public int Id_OBJ { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }
        public int User_id { get; set; }
        public System.DateTime DataAdd { get; set; }
        public int Period_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meters> Meters { get; set; }
        public virtual Periods Periods { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeriodsRead> PeriodsRead { get; set; }
    }
}
