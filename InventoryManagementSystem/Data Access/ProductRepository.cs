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
        
        public List<Product> GetAllProducts()//fetch all products from the database
        {
            List<Product> products = new List<Product>();   
            string query = "SELECT ProductID, ProductName, Price, ProductDesc, StockQuantity FROM ProductTable"; //task1: create a table in the database with the same name and columns

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
                                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                    ProductDesc = reader.IsDBNull(reader.GetOrdinal("ProductDesc")) ? null : reader.GetString(reader.GetOrdinal("ProductDesc")),
                                    StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity"))
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
        //data access method to add a new product to the database
        public bool AddProduct(Product product)
        {
            string query = @"INSERT INTO ProductTable 
                (ProductName, Price, ProductDesc, StockQuantity) 
                VALUES (@Name, @Desc, @Price, @StockQuantity)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", product.ProductName);
                    command.Parameters.AddWithValue("@Desc", product.ProductDesc);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery(); 
                        return rowsAffected > 0; //if one or more rows were affected, the insert was successful
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL Error (AddProduct): " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
