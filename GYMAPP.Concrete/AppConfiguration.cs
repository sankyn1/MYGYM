using GYMAPP.Interface;
using Microsoft.Extensions.Configuration;

namespace GYMAPP.Concrete
{
    public class AppConfiguration : IAppConfiguration
    {
        public IConfiguration _configuration { get; }

        public AppConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            return _configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}