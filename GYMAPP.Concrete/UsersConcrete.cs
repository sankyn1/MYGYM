using GYMAPP.Interface;
using System.Data;
using System.Data.SqlClient;

namespace GYMAPP.Concrete
{
    public class UsersConcrete : IUsers
    {
        public bool AuthenticateUsers(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var result = cnn.Query<Data>("spGetData", new { Id = 1 },
                commandType: CommandType.StoredProcedure);
            }
            return result > 0 ? true : false;
        }
    }
}