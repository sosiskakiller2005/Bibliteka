//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliteka.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shift
    {
        public Shift()
        {
            this.ShiftStaff = new HashSet<ShiftStaff>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual ICollection<ShiftStaff> ShiftStaff { get; set; }
    }
}
