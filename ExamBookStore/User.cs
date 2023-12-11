using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBookStore
{
    internal class User
    {
        private int id { get; set; }
        private string login, password;


        public string Login { get { return login; } set { login = value; } }

        public string Password { get { return password; } set { password = value; } }

        public User() { }

        public User(string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }
    }
}
