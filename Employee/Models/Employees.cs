using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employees
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();
        [Required]
        public string fullName { get; set; }
        [Required]
        public string gender { get; set; }
        [Phone]
        public string phone { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public decimal salary { get; set; }
        public int status { get; set; }

        public Employees(string fullName, string gender, string phone, string email, decimal salary, int status)
        {
            this.fullName = fullName;
            this.gender = gender;
            this.email = email;
            this.salary = salary;
            this.status = status;
        }

        public Employees() { }
    }
}
