using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Team01Section01Project.Models;


namespace MSACSDegreePlanner.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermID { get; set; }
        public int StudentID { get; set; }
        public int Term { get; set; }
        public string TermLabel { get; set; }

        //public Student Student { get; set; }
        //[ForeignKey("StudentID")]


    }
}
