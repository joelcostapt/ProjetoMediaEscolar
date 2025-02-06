using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMediaEscolar
{
    public class User
    {
        public string Username {  get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string username, string name, string password)
        {
            Username = username;
            Name = name;
            Password = password;
        }
    }
}
