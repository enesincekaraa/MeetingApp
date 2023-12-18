using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

 
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo userInfo) {
            if(ModelState.IsValid)
            {
            Repository.Create(userInfo);
            ViewBag.UserCount = Repository.users.Where(i => i.WillAttend == true).Count();
            return View("Thanks",userInfo);
            }
            else 
            {
                return View(userInfo);
            }
        }

        public IActionResult List()
        {
          
            return View(Repository.users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
