using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MCC02.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(string name)
        //{
        //    return "Hello index";
        //}

        //public IActionResult index()
        //{
        //    //var result = new ContentResult();
        //    //result.Content = "hello index";
        //    //result.StatusCode = (int)HttpStatusCode.OK;
        //    //result.ContentType = "text/html";
        //    return Content("");
        //}

        //public RedirectResult update()
        //{
        //    var result = new RedirectResult("https://www.google.com");
        //    return result;

        //}
        public IActionResult update()
        {
            //var result = new RedirectToActionResult(nameof(ProductsControllers.Get), 
            //    "products", new {id=10});
            return RedirectToAction("Index","");
        }
        
            public IActionResult Index()
            {
                return View();   
            }
        [HttpGet]
         public IActionResult privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

    }
}
