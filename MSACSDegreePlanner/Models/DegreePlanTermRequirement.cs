using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MSACSDegreePlanner.Models;

namespace MSACSDegreePlanner.Models
{
    public class DegreePlanTermRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanTermRequirementId { get; set; }

        [ForeignKey("DegreePlanId")]
        public int DegreePlanId { get; set; }

        [ForeignKey("StudentTermId")]
        public int StudentTermId { get; set; }
        //[ForeignKey("RequirementID")]
        public int RequirementId { get; set; }

        //[ForeignKey("DegreePlanID")]
        //public DegreePlan DegreePlan { get; set; }
        //[ForeignKey("RequirementID")]

        public Requirement Requirement { get; set; }
        //[ForeignKey("TermID")]
        public StudentTerm StudentTerm { get; set; }
        public bool Done { get; set; }
    }
}
