using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Models.Entities
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        public string CountryName { get; set; }

        [Required]
        public int ContinentId { get; set; }

        [Required]
        public string Manager { get; set; }

        [Required]
        public DateTimeOffset CreatedDate { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
