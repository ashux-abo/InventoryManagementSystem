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
    public partial class MainForm : Form
    {
        private string email;
        public MainForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            displayEmail.Text = email;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
