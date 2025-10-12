using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserControl
{
    public partial class ProductsPage : System.Windows.Forms.UserControl
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void ProductsPage_Load(object sender, EventArgs e)
        {

        }

        public delegate void NavigateEventHandler(object sender, EventArgs e);
        public event NavigateEventHandler NavigateToSupplierPage;

        protected virtual void OnNavigateToSupplierPage(EventArgs e)
        {
            NavigateToSupplierPage?.Invoke(this, e);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OnNavigateToSupplierPage(EventArgs.Empty);

        }
    }
}
