using Garage2.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garage2.Controllers
{
    public class ReceiptController : Controller
    {

        // GET: Receipt
        public ActionResult Compute()
        {

            vehicle car = (vehicle)TempData["Vehicle"];
            ViewData["reg"] = car.RegNumber;
            ViewData["brand"] = car.Brand;

            DateTime startTime = car.ParkedTime;
            DateTime endTime = DateTime.Now;
            TimeSpan diff = endTime - startTime;
            double hours = diff.TotalHours;
            int hour = (int)Math.Round(hours);
            ViewData["hour"] = hour;
            int pricePerHour = 60;


            int cost = Convert.ToInt32(hours * pricePerHour);
            ViewData["cost"] = cost;
            if (car == null)
            {
                return HttpNotFound();
            }

            return View();
        }
    }
}