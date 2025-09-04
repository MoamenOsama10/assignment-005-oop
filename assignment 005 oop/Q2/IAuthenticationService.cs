using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_005_oop.Q2
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);

        bool AuthorizeUser(string username, string role);
    }
}
