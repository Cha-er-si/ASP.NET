using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial_By_TimCorey.Models;

namespace Tutorial_By_TimCorey.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel person = new PersonModel();
            int i = 5 / person.age;
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { firstName = "Prince", lastName = "Charles", age = 22 });
            people.Add(new PersonModel { firstName = "Jr", lastName = "Bagaporo", age = 21 });
            people.Add(new PersonModel { firstName = "John", lastName = "Doe", age = 34 });

            return View(people);
        }
    }
}