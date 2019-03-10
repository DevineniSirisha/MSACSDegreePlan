using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Team01Section01Project.Models;

namespace MSACSDegreePlanner.Models
{
    public class DegreePlanTermRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanTermRequirementID { get; set; }
        //[ForeignKey("DegreePlanID")]
        public int DegreePlanID { get; set; }
        //[ForeignKey("TermID")]
        public int TermID { get; set; }
        //[ForeignKey("RequirementID")]
        public int RequirementID { get; set; }

        //[ForeignKey("DegreePlanID")]
        //public DegreePlan DegreePlan { get; set; }
        //[ForeignKey("RequirementID")]
        //public Requirement Requirement { get; set; }
        //[ForeignKey("TermID")]
        //public StudentTerm StudentTerm { get; set; }

    }
}
