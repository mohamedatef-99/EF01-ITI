using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EF01_ITI.Entities
{
    // Data Annotation
    class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [ForeignKey("Instuctor")]
        public int Ins_Id { get; set; }
        public DateTime Hiring_Date { get; set; }
    }
}
