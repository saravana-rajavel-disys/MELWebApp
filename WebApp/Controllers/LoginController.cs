using BusinessLayer.Implementations.Login;
using BusinessLayer.Interfaces.Login;
using Microsoft.AspNetCore.Mvc;

namespace MEL_Dashboard.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public bool Validate(string userName, string password)
        {
            IValidateLogin validateLogin = new ValidateLogin();

            return validateLogin.IsValid(userName, password);
        }
    }
}
