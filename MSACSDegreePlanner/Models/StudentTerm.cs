using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MSACSDegreePlanner.Models;


namespace MSACSDegreePlanner.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }
        public int StudentId { get; set; }
        public int Term { get; set; }
        public string TermLabel { get; set; }

        //public Student Student { get; set; }
        //[ForeignKey("StudentID")]

        public bool Done { get; set}

    }
}
