namespace Lecture
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Panda
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        public int? Weight { get; set; }

        public string personality { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int? KungFuRanking { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Zoo Zoo { get; set; }

    }
}
