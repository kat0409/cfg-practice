namespace WebApiApp.Data
{
    public class EmployeeSQL
    {
        public const string AddEmployee = @"
            INSERT INTO Employees (Name, Ssn, HireDate, GradeLevel, Password, Username, PhoneNumber, Email, Address, BirthDate)
            VALUES (@name, @ssn, @hireDate, @gradeLevel, @password, @username, @phoneNumber, @email, @address, @birthDate);";

        public string AddToShiftSchedule = @"
            INSERT INTO ShiftSchedules (ShiftStart, ShiftEnd)
            VALUES (@shiftStart, @shiftEnd);";

        public string AddToEmployeeSchedule = @"
            INSERT INTO EmployeeSchedules (Essn, ShiftID, AssignedAt)
            SELECT (@essn, @shiftId, NOW())
            FROM ShiftSchedules s, Employees e
            WHERE s.ShiftStart = @shiftStart AND s.ShiftEnd = @shiftEnd AND e.Name = @name AND e.BirthDate = birthDate;";

        public string AddEmployeeToAttencance = @"
            INSERT INTO EmployeeAttendance (Essn, CurrentDate)
            SELECT (@essn, CURDATE())
            FROM Employees e
            WHERE e.Name = @name AND e.BirthDate = @birthDate";
    }
}
