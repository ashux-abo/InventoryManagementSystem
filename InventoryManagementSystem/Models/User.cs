using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    internal class User
    {
        public  int UserId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public User() { }
    }
}
