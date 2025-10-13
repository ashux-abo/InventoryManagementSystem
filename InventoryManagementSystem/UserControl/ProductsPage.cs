using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.UserControl
{
    public partial class ProductsPage : System.Windows.Forms.UserControl
    {
        private readonly ProductService _repository;
        public ProductsPage()
        {
            InitializeComponent();
            _repository = new ProductService();
            LoadProductData();
        }
        //loads product data into the datagridview
        private void LoadProductData()

        {//fetch product data from the repository
            var productList = _repository.LoadProducts();

            //check if productList is not null or empty
            if (productList != null || productList.Count > 0)
            {
                productsDataGridView.DataSource = productList;
                return;
            }
            else
            {
                productsDataGridView.DataSource = null;
                MessageBox.Show("No products found or an error occurred.");
            }
        }

        private void ProductsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
