using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal class BasicAuthenticationService
    {
        private const string User1 = "mahmoud";
        private const string Password1 = "0112830";
        private const string Role1 = "user";

        private const string User2 = "Eid";
        private const string Password2 = "12345";
        private const string Role2 = "user";

        public bool AuthenticateUser(string username, string password)
        {
            return (username == User1 && password == Password1) || (username == User2 && password == Password2);
        }

        public bool AuthorizeUser(string username, string role)
        {
            return (username == User1 && role == Role1) || (username == User2 && role == Role2);
        }
    }
}
