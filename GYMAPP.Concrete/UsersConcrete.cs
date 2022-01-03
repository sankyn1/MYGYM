using Dapper.Contrib.Extensions;
using GYMAPP.Interface;
using GYMAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMAPP.Concrete
{
    public class UsersConcrete : IUsers
    {
        public bool AuthenticateUsers(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                var myEvent = connection.get<Users>(username, password);
            }
            return result > 0 ? true : false;

        }
    }
}
