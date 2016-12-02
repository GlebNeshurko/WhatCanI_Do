using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhatCanI_Do.Models;
using System.Collections;
using System.Data.Entity;
using System.Data.SqlClient;

namespace WhatCanI_Do.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        DuckPartyContext db = new DuckPartyContext();
        public string Index()
        {
            return "Always waitng for you, honey";
        }
        public ViewResult DuckMoneySort()
        {
                DuckList ducklist = new DuckList
                {
                    Ducks = new List<Duck>
                    {
                        new Duck { Name= "Cat", Family = "Deepwater", id = 0, Money = 100 },
                        new Duck { Name= "Jack", Family = "Greentroops", id = 1, Money = 250 },
                        new Duck { Name= "Henry", Family = "Greentroops", id = 2, Money =  50},
                        new Duck { Name= "Timmy", Family = "Deepwater", id = 3, Money = 1000 },
                        new Duck { Name= "Lisa", Family = "Deepwater", id = 4, Money =  55}
                    }
                };
            var ducksCount = from d in ducklist.Ducks
                             where d.Family.ToUpper() == "DEEPWATER"
                             select d.Money;
            return View("Result", (object)Convert.ToString(ducksCount.Sum() + "From local data"));
        }  
        public ActionResult DuckPartySort()
        {
            return View(db.DuckPartySet);
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}