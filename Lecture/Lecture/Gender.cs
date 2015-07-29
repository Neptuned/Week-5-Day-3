namespace Lecture
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gender
    {
        public Gender()
        {
            Pandas = new HashSet<Panda>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(5)]
        public string abbr { get; set; }

        public virtual ICollection<Panda> Pandas { get; set; }
    }
}
