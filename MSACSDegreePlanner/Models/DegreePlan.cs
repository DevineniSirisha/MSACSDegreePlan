using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Linq;

namespace MSACSDegreePlanner.Models
{
    public class DegreePlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }

        [ForeignKey("DegreeId")]
        public int DegreeId { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 3)]
        [Display(Name = "DegreePlanAbrev")]
        public String DegreePlanAbrev { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "DegreePlanName")]
        public String DegreePlanName { get; set; }

        //Navigation Properties
        public Degree Degree { get; set; }
        public Student student { get; set; }
    }
}
