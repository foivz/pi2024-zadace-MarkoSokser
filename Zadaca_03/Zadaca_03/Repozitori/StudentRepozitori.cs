using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Zadaca_03.Modeli;

namespace Zadaca_03.Repozitori
{
    public class StudentRepozitori
    {
        public static Student GetStudent(int id)
        {
            Student student = null;

            string sql = "SELECT * FROM Students WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(DB.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = CreateObject(reader);
                        }
                    }
                }
            }
            return student;
        }

        public static List<Student> GetStudents()
        {
            var students = new List<Student>();

            string sql = "SELECT * FROM Students";
            using (SqlConnection connection = new SqlConnection(DB.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = CreateObject(reader);
                            students.Add(student);
                        }
                    }
                }
            }
            return students;
        }

        private static Student CreateObject(SqlDataReader reader)
        {
            int id = reader["Id"] != DBNull.Value ? int.Parse(reader["Id"].ToString()) : 0;
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int grade = reader["Grade"] != DBNull.Value ? int.Parse(reader["Grade"].ToString()) : 0;

            var student = new Student
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };

            return student;
        }
    }
}
