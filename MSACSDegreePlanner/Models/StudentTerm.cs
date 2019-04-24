using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MSACSDegreePlanner.Models;


namespace MSACSDegreePlanner.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int StudentTermId { get; set; }

        public int DegreePlanId { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        public int Term { get; set; }

        public string TermLabel { get; set; }

        public Student Student { get; set; }

        public bool Done { get; set; }

        public DegreePlan DegreePlan { get; set; }

        public ICollection<DegreePlanTermRequirement> DegreePlanTermRequirements { get; set; }
    }
}
