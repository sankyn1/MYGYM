using GYMAPP.Models;

namespace GYMAPP.Interface
{
    public interface IUsers
    {
        Users AuthenticateUsers(string username, string password);
    }
}