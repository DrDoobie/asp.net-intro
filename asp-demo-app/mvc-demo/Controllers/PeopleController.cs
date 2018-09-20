using mvc_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople ()
        {
            List<PersonModel> people = new List<PersonModel>();
   
            people.Add(new PersonModel {firstName = "Willie", lastName = "Nelson", birthYear = 1933});
            people.Add(new PersonModel {firstName = "Bobbie", lastName = "Jackson", birthYear = 1968});
            people.Add(new PersonModel {firstName = "Bill", lastName = "Wesley", birthYear = 1754});

            return View(people);
        }
    }
}