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
    
    public partial class PeriodsRead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeriodsRead()
        {
            this.ReadMeters = new HashSet<ReadMeters>();
            this.Recommendations = new HashSet<Recommendations>();
        }
    
        public int Id_PR { get; set; }
        public int id_periods { get; set; }
        public System.DateTime DateP { get; set; }
        public int id_obj { get; set; }
    
        public virtual OBJ OBJ { get; set; }
        public virtual Periods Periods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReadMeters> ReadMeters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recommendations> Recommendations { get; set; }
    }
}