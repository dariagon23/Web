using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Bookshelf.Models;

namespace Bookshelf.Controllers
{
    public class LoginController : Controller
    {

        
        public IActionResult Index() => View();
        [HttpPost]
        public ActionResult Index(string UserLogin, string UserPassword)
        {
            User? user = users.FirstOrDefault(x => x.UserLogin == UserLogin && x.Password == UserPassword);
            if(user is null)
            {
                return RedirectToRoute(new { controller = "Login", action = "Index" });
            }
            else
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
        } 
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        readonly List<User> users = new List<User>
        {
            new User{ UserLogin = "Daria Go", Password = "12345"},
            new User{ UserLogin = "Bob", Password = "54321"},
            new User{ UserLogin = "Rob", Password = "13579"},
            new User{ UserLogin = "Jack", Password = "24680"},
            new User{ UserLogin = "Ann", Password = "86421"},
        };
    }
}
