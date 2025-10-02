using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiApp.Interfaces
{
    public interface IEmployeeRepository
    {
        public enum GL
        {
            Infant,
            Kindergarten,
            Elementary
        }
        Task AddEmployee(string name, string ssn, DateOnly hireDate, GL gradeLevel, string password, string username, string phoneNum, string email, string address);
    }
}
