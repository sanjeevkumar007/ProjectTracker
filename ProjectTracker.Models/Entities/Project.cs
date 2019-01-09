using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Models.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        //[ForeignKey("Country")]
        public int CountryId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        //public virtual Country Countries { get; set; }

    }
}
