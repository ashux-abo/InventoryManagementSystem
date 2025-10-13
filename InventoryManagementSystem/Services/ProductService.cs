using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Data_Access;

namespace InventoryManagementSystem.Services
{
    internal class ProductService
    {
        private readonly ProductRepository _repository;
        public ProductService()
        {
            _repository = new ProductRepository();
        }

        public List<Product> LoadProducts()
        {
            //next task: add business logic and validation here before returning data
            return _repository.GetAllProducts();
        }

        public bool CreateNewProduct(Product product)
        {
            //next task: add business logic and validation here before adding a new product
            return _repository.AddProduct(product);
        }
    }
}
