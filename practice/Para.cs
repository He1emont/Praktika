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
    
    public partial class Para
    {
        public int ID_par { get; set; }
        public int ID_anket { get; set; }
        public int ID_anket2 { get; set; }
    
        public virtual Anket Anket { get; set; }
    }
}
