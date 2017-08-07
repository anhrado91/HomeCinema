namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role:IEntityBase
    {
        public Role()
        {
            UserRoles = new List<UserRole>();
        }    
        public int ID { get; set; }
        public string Name { get; set; }    
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
