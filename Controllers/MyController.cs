using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Session1_BoilerPlate.Interface;
using Session1_BoilerPlate.Services;

namespace Session1_BoilerPlate.Controllers
{
    public class MyController : Controller
    {
        private readonly MyInterface _myInterface;
        private readonly IServiceProvider _serviceProvider;
        public MyController(MyInterface myInterface , IServiceProvider serviceProvider)
        {
            _myInterface = myInterface;
            _serviceProvider = serviceProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                string value = _myInterface.GetMyValue();
                return View(value);

            }
            catch (Exception ex)
            {
                var errorController = _serviceProvider.GetRequiredService<ErrorController>();
                return errorController.MyException();
            }


        }

    }
}
