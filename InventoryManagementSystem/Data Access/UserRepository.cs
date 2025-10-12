using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Data_Access
{
    internal class UserRepository
    {
        private string connectionString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=QuickStockDB;Integrated Security=True;";

        public bool IsEmailToken(string email)
        {
            string query = "SELECT COUNT(*) FROM UserTable WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public User GetEmailToken(string email)
        {
            string query = "SELECT UserId, Email, PasswordHash FROM UserTable WHERE Email = @Email";
            User user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash"))
                        };
                    }
                }
            }
            return user;
        }

        public bool AddUser(User user)
        {
            string query = @"INSERT INTO UserTable(PasswordHash, Email) VALUES
            (@PasswordHash, @Email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        //Log or handle the exception as needed
                        Console.WriteLine("SQL Error:" + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool AddProfileImage(string email, byte[] ImageData)
        {
            string query = "UPDATE UserTable SET ProfileImage = @ProfileImage WHERE Email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.Add("@ProfileImage", SqlDbType.VarBinary, -1).Value = ImageData;
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL Error:" + ex.Message);
                        return false;
                    }
                }
            }
        }

        public byte[] GetProfileImage(string email)
        {
            string query = "Select ProfileImage from UserTable where Email = @Email";
            byte[] photoData = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            photoData = (byte[])result;
                        }   
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL Error:" + ex.Message);
                        return null;
                    }
                }
            }
            return photoData;
        }
    }
}
