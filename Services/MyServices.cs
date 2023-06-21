using Session1_BoilerPlate.Interface;

namespace Session1_BoilerPlate.Services
{
    public class MyServices : MyInterface
    {

        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public MyServices(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public string GetMyValue()
        {
            string a = _configuration["Palash"];
            return a;
        }


    }
}
