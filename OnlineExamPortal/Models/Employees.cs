using Microsoft.Azure.Documents;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Models
{
    public class Employees
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="Name cannot be exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$",
            ErrorMessage ="Invalid Email Format")]
        [DisplayName("Office Email")]
        public string Email { get; set; }
        [EnumDataType(typeof(Dept))]
        public Dept? Department { get; set; }
    }
}
