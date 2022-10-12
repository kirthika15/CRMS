using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRMS.Models
{
    public class Users
    {
        [Key]
        [Column(TypeName = "Guid")]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string UserName { get; set; }

        [Column(TypeName = "Guid")]
        public int DepartmentId { get; set; }

        [Column(TypeName = "Guid")]
        public int UserRoleId { get; set; }

        Departments departments { get; set; }
        UserRoles userRoles { get; set; }
    }
}
