using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MettingApp.Controllers
{
    public class HomeController : Controller{

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            //var selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            //return View(model: selamlama);

            //ViewBag
            //ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            //ViewBag.UserName = "Furkan";
            //cshtml: @ViewBag.Selamlama, @ViewBag.UserName

            //ViewData
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            //ViewData["UserName"] = "Furkan";
            //cshmtl: @ViewData["Selamlama"], @ViewData["UserName"]

            var userCount = Repository.Users.Where(t=>t.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "Istanbul, ABC Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 00, 00),
                NumberOfPeople = userCount
            };

            return View(meetingInfo);
        }
    }
}