using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProgramacionAvanzada.Web.Models;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class PersonController : Controller
    {
        private static List<Person> _persons = new List<Person>
        {
            new Person { Id = "1", Name = "Juan Pérez", Description = "Desarrollador Senior", DateCreated = DateTime.Now.AddDays(-10) },
            new Person { Id = "2", Name = "María García", Description = "Diseñadora UX/UI", DateCreated = DateTime.Now.AddDays(-9) },
            new Person { Id = "3", Name = "Carlos López", Description = "Project Manager", DateCreated = DateTime.Now.AddDays(-8) },
            new Person { Id = "4", Name = "Ana Martínez", Description = "QA Tester", DateCreated = DateTime.Now.AddDays(-7) },
            new Person { Id = "5", Name = "Luis Rodríguez", Description = "DevOps Engineer", DateCreated = DateTime.Now.AddDays(-6) },
            new Person { Id = "6", Name = "Carmen Sánchez", Description = "Business Analyst", DateCreated = DateTime.Now.AddDays(-5) },
            new Person { Id = "7", Name = "Miguel Torres", Description = "Frontend Developer", DateCreated = DateTime.Now.AddDays(-4) },
            new Person { Id = "8", Name = "Laura Jiménez", Description = "Backend Developer", DateCreated = DateTime.Now.AddDays(-3) },
            new Person { Id = "9", Name = "Roberto Díaz", Description = "Database Administrator", DateCreated = DateTime.Now.AddDays(-2) },
            new Person { Id = "10", Name = "Patricia Ruiz", Description = "Scrum Master", DateCreated = DateTime.Now.AddDays(-1) }
        };

        public ActionResult Index()
        {
            return View(_persons);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                person.Id = (_persons.Count + 1).ToString();
                person.DateCreated = DateTime.Now;
                _persons.Add(person);
            }
            return View("Index", _persons);
        }
    }
}