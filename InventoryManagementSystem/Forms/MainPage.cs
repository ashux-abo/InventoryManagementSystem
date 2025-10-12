using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Data_Access;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.UserControl;

namespace InventoryManagementSystem.Forms
{
    public partial class MainPage : Form
    {
        //to hold the email of the logged-in user
        private string email;
        private readonly UserRepository userRepository;
        private readonly UserService userService;
        public MainPage(string email)
        {
            InitializeComponent();
            this.email = email;
            userRepository = new UserRepository();
            userService = new UserService();
            
            LoadUserControl(new DashboardControl());
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            displayEmail.Text = email;
           
        }

        private void LoadUserControl(System.Windows.Forms.UserControl userControl)
        {
            panel2.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl);
        }

        //handles button clicks to load respective user controls
        private void productsBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ProductsPage());
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
           LoadUserControl(new SupplierPage());
        }

        private void transactionsBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TransactionPage());
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReportPage());
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashboardControl());
        }
    }
}
