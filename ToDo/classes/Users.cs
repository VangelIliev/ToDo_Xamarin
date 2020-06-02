using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ToDo
{
     public class Users
     {
        
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string GetUsername()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }

        
    }
}
