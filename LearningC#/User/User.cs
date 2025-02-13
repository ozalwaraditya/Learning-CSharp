using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.User
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private string _email;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { set => _password = value; }
        public string Email { get => _email; set => _email = value; }

        public User(string username, string password, string email, int id)
        {
            _username = username;
            _password = password;
            _email = email;
            _id = id;
        }

        public void toPrint()
        {
            Console.WriteLine($"Id: {_id}, Username: {_username}, Email: {_email}");
        }

        public bool verifyPassword(string passwword)
        {
            if (string.IsNullOrEmpty(passwword)) return false;
            if (passwword == _password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
