namespace WebApiApp.Data
{
    public class EmployeeSQL
    {
        public const string AddEmployee = @"
            INSERT INTO Employees (Name, Ssn, HireDate, GradeLevel, Password, Username, PhoneNumber, Email, Address)
            VALUES (@name, @ssn, @hireDate, @gradeLevel, @password, @username, @phoneNumber, @email, @address);";


    }
}
