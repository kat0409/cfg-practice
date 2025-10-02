namespace WebApiApp.Data
{
    public class EmployeeSQL
    {
        public const string AddEmployee = @"
            INSERT INTO Employees (Name, Ssn, HireDate, GradeLevel, Password, Username, PhoneNumber, Email, Address)
            VALUES (@name, @ssn, @hireDate, @gradeLevel, @password, @username, @phoneNumber, @email, @address);";

        public string AddToShiftSchedule = @"
            INSERT INTO ShiftSchedules (ShiftStart, ShiftEnd)
            VALUES (@shiftStart, @shiftEnd);";

        public string AddToEmployeeSchedule = @"
            INSERT INTO EmployeeSchedules (Essn, ShiftID, AssignedAt)
            VALUES (@essn, @shiftId, NOW());";
    }
}
