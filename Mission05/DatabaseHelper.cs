using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mission05
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=DESKTOP-RIJACBF\\SQLEXPRESS;Database=Mission5CSharp;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static void AddEmployee(Employee employee)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)", conn);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Position", employee.Position);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateEmployee(Employee employee)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employees SET Name=@Name, Position=@Position, Salary=@Salary WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Position", employee.Position);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteEmployee(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllEmployees()
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable SearchEmployees(string keyword)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE Name LIKE @Keyword OR Position LIKE @Keyword", conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}