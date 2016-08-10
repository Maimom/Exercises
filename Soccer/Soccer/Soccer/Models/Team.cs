using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Soccer.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        [Required]
        [Display (Name ="Team Name")]
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime Founded { get; set; }
        public virtual ICollection<Player> Players { get; set; } 
    }
}