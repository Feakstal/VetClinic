//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vet.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int IDUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> IDRole { get; set; }
        public Nullable<int> IDEmployee { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
