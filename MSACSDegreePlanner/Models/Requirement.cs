using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSACSDegreePlanner.Models
{
    public class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequirementId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Requirement Abbreviation")]
        public String RequirementAbbrev { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Requirement Name")]
        public String RequirementName { get; set; }

        public int DegreeId { get; set; }

        public Degree degree { get; set; }
    }
}
