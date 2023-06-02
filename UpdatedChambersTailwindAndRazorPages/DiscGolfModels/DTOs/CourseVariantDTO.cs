using UpdatedChambersTailwindAndRazorPages.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedChambersTailwindAndRazorPages.Models.DTOs
{
    public class CourseVariantDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public CourseDTO Course { get; set; }
        public bool Deleted { get; set; }
    }
}
