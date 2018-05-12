using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class UserDto
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public UserDto(string user, string password, string name)
        {
            User = user;
            Password = password;
            Name = name;
        }
    }
}
