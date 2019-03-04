using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Team01Section01Project.Models;

namespace MSACSDegreePlanner.Models
{
    public class DegreeRequirement
    {
        public int DegreeRequirementID { get; set; }
        public int DegreeID { get; set; }
        public int RequirementID { get; set; }

        //public Degree Degree { get; set; }
        //[ForeignKey("DegreeID")]

        //public Requirement Requirement { get; set }
        //[ForeignKey("RequirementID")]

        //public Requirement Requirement { get; set; }

    }
}
