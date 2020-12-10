using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Application_3._0
{
    class User
    {
        public string Username;
        public string Password;
        public int Score;

        public User() { }

        public User(string username, string password, int score)
        {
            Username = username;
            Password = password;
            Score = score;
        }
    }
}
