using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSACSDegreePlanner.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Degree Abbreviation")]
        public String DegreeAbbrev { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Degree Plan Name")]
        public String DegreePlanName { get; set; }
    }

}
