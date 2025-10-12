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
        private string email;
        private readonly UserRepository userRepository;
        private readonly UserService userService;
        public MainPage(string email)
        {
            InitializeComponent();
            this.email = email;
            userRepository = new UserRepository();
            userService = new UserService();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            displayEmail.Text = email;
        }
    }
}
