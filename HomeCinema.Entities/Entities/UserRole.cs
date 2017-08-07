namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRole:IEntityBase
    {
        public int ID { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> RoleId { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
