using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSACSDegreePlanner.Models
{
    public class Requirement
    {
        public int RequirementID { get; set; }
        [StringLength(8, MinimumLength = 3)]
        public String RequirementAbbrev { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public String RequirementName { get; set; }
    }
}
