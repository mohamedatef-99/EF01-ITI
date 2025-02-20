using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01_ITI.Entities
{
    // Data Annotation
    class Course_Inst
    {
        [Key]
        public int Ins_Id { get; set; }
        public int Course_Id { get; set; }
        public string Evaluate { get; set; }
    }
}
