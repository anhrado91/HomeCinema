namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer:IEntityBase
    {
        public Customer()
        {
            Rentals = new List<Rental>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityCard { get; set; }
        public string UniqueKey { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }    
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
