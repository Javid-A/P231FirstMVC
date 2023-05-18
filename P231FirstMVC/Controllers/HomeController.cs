using Microsoft.AspNetCore.Mvc;

namespace P231FirstMVC.Controllers
{
    public class HomeController:Controller
    {
        public ContentResult Hello()
        {
            return Content("Hello P231 Content");
        }

        public JsonResult Datas()
        {
            var obj = new
            {
                Name= "Rahim",
                Surname="Valiyev"
            };
            return Json(obj);
        }

        public ViewResult NewView()
        {
            ViewResult view = new()
            {
                ViewName = "NewView"
            };
            return view;
            //return View();
        }

        public IActionResult Index()
        {
            //return Json("");
            //return Content("");
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }
    }
}
