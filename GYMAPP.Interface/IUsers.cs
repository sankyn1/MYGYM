using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMAPP.Interface
{
    public interface IUsers
    {
        bool AuthenticateUsers(string username, string password);
    }
}
