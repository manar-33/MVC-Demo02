using Microsoft.AspNetCore.Mvc;
using MVC_Demo02.Models;

namespace MVC_Demo02.Controllers
{
    public class MoviesController : Controller
    {
        //public string Test()
        //{
        //    return "Default Path";
        //}
        //public string GetMovie (int id)
        //{
        //    return $"id : {id}";
        //}

        public IActionResult GetMovie(int? id, string name, Movie movie)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"id : {id}";
            //result.ContentType = "text/html";

            //return result;

            return Content($"id : {id}", "text/html");
        }

        //public IActionResult Test(int? id)
        //{
        //    if (id is null)
        //    {
        //        //RedirectResult result = new RedirectResult("https://www.google.com/");
        //        //return result;
        //        return Redirect("https://www.google.com/");
        //    }
        //    else
        //    {
        //        //RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = id });
        //        //return result;
        //        return RedirectToAction("GetMovie", "Movies", new { id = id });
        //    }

        //}

        //public IActionResult Test01(int? id)
        //{
        //    RedirectResult result;
        //    if (id == 1)
        //    {
        //        result = new RedirectResult("https://www.google.com/");


        //    }
        //    else
        //    {
        //        result = new RedirectResult("https://www.facebook.com/");
        //    }
        //    return result;
        //}
        //public RedirectResult Test02()
        //{
        //    RedirectResult result = new RedirectResult("https://www.facebook.com/");
        //    return result;
        //}
    }
}
