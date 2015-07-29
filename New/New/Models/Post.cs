using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace New.Models
{
    public class Post
    {
        public int Id {get ; set; } 
        [Required]
        [MaxLength(100)]
           public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public  DateTime PublishedOn { get; set; }


    }
}