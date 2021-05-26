using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //fields
        private string _userName;
        private string _password;
        //properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        //ctors
        public Login()
        {

        }
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        //methods
        public override string ToString()
        {
            return string.Format("Username: {0}\n" +
                "Password: {1}",
                UserName, Password);
        }
    }
}
