using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DayFinder.Models;

namespace DayFinder.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View("Index", "");
        }

        [HttpPost("/result")]
        public ActionResult Result()
        {
          int yearVal = int.Parse(Request.Form["year"]);
          int monthVal = int.Parse(Request.Form["month"]);
          int dayVal = int.Parse(Request.Form["day"]);
          DayFind newDayFind = new DayFind(yearVal, monthVal, dayVal);
          string model = newDayFind.ReturnDayOfWeek() + " is the day of the week based on the date you entered: " + monthVal + "/" + dayVal + "/" + yearVal + "." ;
          return View("Index", model);
        }


    }
}
