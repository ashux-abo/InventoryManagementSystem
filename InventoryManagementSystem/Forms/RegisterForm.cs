using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class RegisterForm : Form
    {
        LoginForm loginForm;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 
            loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
