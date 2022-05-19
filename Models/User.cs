using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authentication_jwt.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public User(string username, string role, string password)
        {
            Username = username;
            Role = role;
            Password = password;
        }
    }
}
