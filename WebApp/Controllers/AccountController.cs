using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public IActionResult SignUp()
            
        {
            ViewData["Title"] = "Sign Up";
            var viewModel = new SignUpViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel viewModel)

        {
            if (!ModelState.IsValid) 
            return View(viewModel);

            return RedirectToAction("SignIn", "Account");
        }
    }
}
