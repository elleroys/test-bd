using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Animalpedia
{
    abstract class Client // Клієнт
    {
        public string Id { get; protected set; }
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public string Access { get; protected set; }

        public Client(string id, string login, string password, string access)
        {
            Id = id;
            Login = login;
            Password = password;
            Access = access;
        }
    }

    class User : Client
    {
        public string Authorized { get; protected set; }
        public User(string id, string login, string password, string access, string authorized)
            : base(id, login, password, access)
        {
            Authorized = authorized;
        }
    }

    class Admin : Client
    {
        public string Authorized { get; protected set; }
        public Admin(string id, string login, string password, string access, string authorized)
            : base(id, login, password, access)
        {
            Authorized = authorized;
        }
    }
}