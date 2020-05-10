using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedirectResultActionsCoreMvc_Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Office { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public int Salary { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
