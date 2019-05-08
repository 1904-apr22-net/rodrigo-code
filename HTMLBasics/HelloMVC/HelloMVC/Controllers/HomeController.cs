using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    //[Route("House")]
    //Attribute routing is an alternative to conventional writing.
    public class HomeController : Controller
    {
        //controllers have "action methods"
        //each action method is meant to handle a request to one path
        // it should return a ViewResult to be rendered into HTML
        // and sent as a HTTP response

        // this index methid handles requests to the following paths:
        //- /
        //- /Home
        //- /Home/Index
        // because of the conventional 
        public IActionResult Index()
        {
            //this is helper method from the parent class
            // View() searches for and returns the view which has the same
            //as the current action method

            //now that index view is strongly-typed for Timestamp we have to give it a value.
            var model = new TimeStamp{ Value = DateTime.Now};

            return View(model);
        }

        public IActionResult Privacy()
        {
            //"get the Home/Piracy" view and return it
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
