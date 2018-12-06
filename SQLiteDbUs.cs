using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDb
{
    class LoginAuthentication
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string checkLogin()
        {
            string query;
            query = $"SELECT * FROM userLogin where userID= {Username} " 
                $"+ userPass = {Password}
        }
    }
}
