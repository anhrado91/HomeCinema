namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Error:IEntityBase
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    }
}
