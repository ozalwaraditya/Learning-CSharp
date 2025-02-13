using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class UserCredential
    {
        private int _id;
        private string _username;
        private string _password;
        private string _email;

        UserCredential(string username, string password, string email, int id)
        {
            this._username = username;
            this._password = password;
            this._email = email;
            this._id = id;
        }

        public void printCompleteInformation()
        {
            Console.WriteLine($"username  : {_username} ," +
                $"email : {_email}");
        }

    }
}
