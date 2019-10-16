using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public string DateEmploymentStarted { get; set; }
        public int TotalRows { get; set; }
    }
}
