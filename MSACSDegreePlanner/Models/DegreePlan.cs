using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team01Section01Project.Models
{
    public class DegreePlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanID { get; set; }
        public int DegreeID { get; set; }
        public int StudentID { get; set; }
        public String DegreePlanAbrev { get; set; }
        public String DegreePlanName { get; set; }
    }
}
