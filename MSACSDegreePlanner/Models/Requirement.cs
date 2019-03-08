﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MSACSDegreePlanner.Models
{
    public class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequirementID { get; set; }
        public String RequirementAbbrev { get; set; }
        public String RequirementName { get; set; }
    }
}
