using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSACSDegreePlanner.Models
{
    public class Degree
    {
        public int DegreeID { get; set; }
        [StringLength(8, MinimumLength = 3)]
        public String DegreeAbbrev { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public String DegreePlanName { get; set; }
    }

}
