using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Models
{
    [Table("Product", Schema = "Core")]
    public class Product
    {
        public Product()
        {
            CreatedDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]
        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string ImageName { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string ImagePath { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
