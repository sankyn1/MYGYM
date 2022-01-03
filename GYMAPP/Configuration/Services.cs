namespace GYMAPP.Configuration
{
    public class Services
    {
        public IConfiguration Configuration { get; }
        public Services(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

        }
    }
}
