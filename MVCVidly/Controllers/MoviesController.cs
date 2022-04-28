using Microsoft.AspNetCore.Mvc;
using MVCVidly.Models;

namespace MVCVidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Sherek" };

            //return View(movie);
            //return Content("Hello world"); //return a result as a text 
            //return NotFound();  // it doens't work! nither
            //return new EmptyResult(); // a empty page as a response
            return RedirectToAction("Index", "Home", new {sortby = false, page = 1 }); //firs argument:action, secondone: controller, thrid argument, specify some parameter as a query stirng
        }

        public IActionResult Edit(int id) //the aps.net authomatically get id from query, param, or body of request and pass to id
        {
            return Content($"this is the id your wrote: {id}");
        }

        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }

            return Content($"pageIndex = {pageIndex}, sortby = {sortBy}");
        }
    }
}
