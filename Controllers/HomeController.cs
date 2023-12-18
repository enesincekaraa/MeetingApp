using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers

{
    public class HomeController : Controller 
    {
        public IActionResult Index() 
        {
            int saat = DateTime.Now.Hour;            
            //ViewBag.Selamlama= saat > 12 ? "İyi Günler" : "Günaydın";


            ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "Günaydın";
            int UserCount=Repository.users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul Kongre Merkezi",
                Date = DateTime.Now,
                NumberOfPeople = UserCount
            };
            
            return View(meetingInfo);
        }
    }

}
