using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_005_oop.Q2
{
    public class BasicAuthenticationService: IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "admin" && role == "admin")
            {
                return true;
            }
            return false;
        }
    }
 }
