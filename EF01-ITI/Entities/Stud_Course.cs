﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01_ITI.Entities
{
    // Data Annotaion
    class Stud_Course
    {
        [Key]
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int Grade { get; set; }
    }
}
