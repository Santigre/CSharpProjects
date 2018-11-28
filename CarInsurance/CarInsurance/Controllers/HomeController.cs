using System;
using CarInsurance.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddQuote(DateTime dateOfBirth, int carYear, string carMake, string carModel, int speedingTickets, bool dui, bool fullCoverage)
        {
            var BaseQuote = 50;

            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = new Insuree();
                insuree.DateOfBirth = dateOfBirth;
                int Age = DateTime.Now.Year - dateOfBirth.Year;
                if (Age < 25 || Age > 100)
                {
                    BaseQuote += 25;
                }
                if (Age < 18)
                {
                    BaseQuote += 100;
                }

                insuree.CarYear = carYear;
                if (carYear < 2000 || carYear > 2015)
                {
                    BaseQuote += 25;
                }

                insuree.CarMake = carMake.ToLower();
                insuree.CarModel = carModel.ToLower();
                if (carMake == "porsche")
                {
                    BaseQuote += 25;
                }

                if (carMake == "porsche" && carModel == "911 carrera")
                {
                    BaseQuote += 25;
                }

                insuree.SpeedingTickets = speedingTickets;
                if (speedingTickets > 0)
                {
                    BaseQuote = speedingTickets * 10;
                }

                insuree.DUI = dui;
                if (dui == true)
                {
                    BaseQuote = BaseQuote + (BaseQuote / 4);
                }

                insuree.CoverageType = fullCoverage;
                if (fullCoverage == true)
                {
                    BaseQuote = BaseQuote + (BaseQuote / 2);
                }

                insuree.Quote = BaseQuote;
                db.SaveChanges();

            }
            return View();
        }
    }
}