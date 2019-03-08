using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team01Section01Project.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Snumber { get; set; }
        public int _919number { get; set; }
    }
}
