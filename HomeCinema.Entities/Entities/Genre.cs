namespace HomeCinema.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Genre:IEntityBase
    {     
        public Genre()
        {
            Movies = new List<Movie>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }          
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
