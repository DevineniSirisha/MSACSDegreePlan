using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team01Section01Project.Models
{
    public class DegreePlan
    {
        public int DegreePlanID { get; set; }
        public int DegreeID { get; set; }
        public int StudentID { get; set; }
        [StringLength(8, MinimumLength = 3)]
        public String DegreePlanAbrev { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public String DegreePlanName { get; set; }
    }
}
