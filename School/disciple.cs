//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School
{
    using System;
    using System.Collections.Generic;
    
    public partial class disciple
    {
        public int id { get; set; }
        public string fio { get; set; }
        public Nullable<int> id_class { get; set; }
        public Nullable<int> p_year { get; set; }
    
        public virtual classrooms classrooms { get; set; }
    }
}
