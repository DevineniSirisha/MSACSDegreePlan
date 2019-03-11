using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MSACSDegreePlanner.Models;

namespace MSACSDegreePlanner.Models
{
    public class DegreeRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeRequirementId { get; set; }
        public int DegreeId { get; set; }
        public int RequirementId { get; set; }

        public Degree Degree { get; set; }
        public Requirement Requirement { get; set; }

        //public Degree Degree { get; set; }
        //[ForeignKey("DegreeID")]

        //public Requirement Requirement { get; set }
        //[ForeignKey("RequirementID")]

        //public Requirement Requirement { get; set; }

    }
}
