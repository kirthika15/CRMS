using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRMS.Models
{
    public class Departments
    {
        [Key]
        [Column(TypeName = "Guid")]
        public int DepartmentId { get; set; }

        [Column (TypeName = "nvarchar(200)")]
        public string DepartmentName { get; set; }
    }
}
