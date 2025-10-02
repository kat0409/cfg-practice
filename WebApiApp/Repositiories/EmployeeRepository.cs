using MySql.Data;
using MySqlConnector;
using System;
using System.Threading.Tasks;
using WebApiApp.Models;
using WebApiApp.Data;

namespace WebApiApp.Repositiories
{
    public class EmployeeRepository
    {
        private readonly string _connectionString;
        private readonly EmployeeSQL _employeeSql;

        public enum GL
        {
            Infant,
            Kindergarten,
            Elementary
        }

        public EmployeeRepository(string connectionString, EmployeeSQL employeeSql)
        {
            _connectionString = connectionString;
            _employeeSql = employeeSql;
        }

        public async Task AddEmployee(string name, string ssn, DateOnly hireDate, GL gradeLevel, string password, string username, string phoneNum, string email, string address)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(EmployeeSQL.AddEmployee, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@ssn", ssn);
            cmd.Parameters.AddWithValue("@hireDate", hireDate);
            cmd.Parameters.AddWithValue("@gradeLevel", gradeLevel);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@hireDate", hireDate);
            cmd.Parameters.AddWithValue("@phoneNum", phoneNum);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task AddToShiftSchedule(DateTime shiftStart, DateTime shiftEnd)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand(_employeeSql.AddToShiftSchedule, conn);

            cmd.Parameters.AddWithValue("@shiftStart", shiftStart);
            cmd.Parameters.AddWithValue("@shiftEnd", shiftEnd);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }
    }
}
