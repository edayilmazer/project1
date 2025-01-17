using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller // HomeController adında bir denetleyici sınıfı oluşturur ve bu sınıf Controller sınıfından türetilir. 
    {
        //localhost
        //localhost/home
        //localhost/home/index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            //ViewBag.UserName = "Eda";

            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewData["UserName"] = "Eda";

            var meetingInfo = new MeetingInfo()
            {
                Id= 1,
                Location = "İzmir",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = 100
            };

            return View(meetingInfo); 
        }
    }
}