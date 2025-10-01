using System.ComponentModel.DataAnnotations;

namespace WebApiApp.Models
{
    public class Employees
    {
        public string Name { get; set; }
        public string Ssn { get; set; }
        public DateOnly HireDate { get; set; }
        public enum GL
        {
            Infant,
            Kindergarten,
            Elementary
        }
        public GL GradeLevel { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string PhoneNumber {  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
