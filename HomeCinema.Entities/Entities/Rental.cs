namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental:IEntityBase
    {
        public int ID { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> StockId { get; set; }
        public Nullable<System.DateTime> RetalDate { get; set; }
        public string Status { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
