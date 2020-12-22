using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services;

namespace WebProjectForPribylskaya.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignIn(string login, string password)
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignUp()
        {
            return View();
        }
    }
}