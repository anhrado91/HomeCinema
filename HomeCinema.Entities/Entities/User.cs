namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            UserRoles = new List<UserRole>();
        }
    
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
