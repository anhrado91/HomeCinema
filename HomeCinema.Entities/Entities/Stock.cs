namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class Stock:IEntityBase
    {
        public Stock()
        {
            Rentals = new List<Rental>();
        }

        public int ID { get; set; }
        public Nullable<int> MovieId { get; set; }
        public string UniqueKey { get; set; }
        public Nullable<bool> IsAvailable { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
