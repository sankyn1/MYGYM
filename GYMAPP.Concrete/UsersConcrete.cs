using Dapper;
using GYMAPP.Interface;
using GYMAPP.Models;
using System.Data;
using System.Data.SqlClient;

namespace GYMAPP.Concrete
{
    public class UsersConcrete : IUsers
    {
        private readonly IAppConfiguration _appConfiguration;

        public UsersConcrete(IAppConfiguration appConfiguration)
        {
            _appConfiguration = appConfiguration;
        }

        public Users AuthenticateUsers(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_appConfiguration.GetConnectionString()))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Email", username);
                parameters.Add("@Password", password);

                var loginUserData = SqlMapper.Query<Users>(connection, "UserLogin", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return loginUserData;
            }
        }
    }
}