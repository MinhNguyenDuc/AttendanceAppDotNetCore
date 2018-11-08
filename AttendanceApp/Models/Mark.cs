using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceApp.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }

        public int SubjectId { get; set; }
        public string StudentRollNumber { get; set; }
        public int StudentMark { get; set; }

        [ForeignKey("StudentRollNumber")]
        public Student Student { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}
