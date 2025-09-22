using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Data_Access;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    internal class AuthService
    {
        private readonly UserRepository userRepository;
        private readonly SecurityService securityService;
        public AuthService()
        {
            userRepository = new UserRepository();
            securityService = new SecurityService();
        }

        public bool AuthenticateUser(string email, string password)
        {
            User user = userRepository.GetEmailToken(email);
            if(user == null)
            {
                MessageBox.Show("Email does not exist.", "Error", MessageBoxButtons.OK);
                return false; 
            }

            return securityService.VerifyPassword(password, user.PasswordHash);
        }
    }
}
