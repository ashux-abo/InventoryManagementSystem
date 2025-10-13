using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Data_Access
{
    internal class ProductRepository
    {
        private string connectionString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=QuickStockDB;Integrated Security=True;";
        
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();   
            string query = "SELECT ProductID, Name, Price, Description, StockQuantity FROM ProductTable"; //task1: create a table in the database with the same name and columns

            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new Product
                                {
                                    ProductID = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Price = reader.GetDecimal(2),
                                    Description = reader.GetString(1),
                                    StockQuantity = reader.GetInt32(3)
                                });
                            }
                        }
                    }
                    catch(SqlException ex)
                    {
                        Console.WriteLine("SQL Error (GetAllProducts): " + ex.Message);
                    }
                }
            }
            return products;
        }

    }
}
