using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string AnswerId { get; set; }
        //[ForeignKey("Fk_Subject_Id_Key")]
        public string SubjectId { get; set; }
        //[ForeignKey("Fk_Domain_Id_Key")]
        public string DomainId { get; set; }
        public bool IsTrialExam { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
