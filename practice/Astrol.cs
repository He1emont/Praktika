//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Astrol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Astrol()
        {
            this.Test_astrol = new HashSet<Test_astrol>();
        }
    
        public int ID_astrol { get; set; }
        public string Familiy { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test_astrol> Test_astrol { get; set; }
    }
}
