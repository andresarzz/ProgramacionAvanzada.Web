using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProgramacionAvanzada.Web.Models;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class JobController : Controller
    {
        private static List<Job> _jobs = new List<Job>
        {
            new Job { Id = "1", Name = "Desarrollador .NET", Description = "Desarrollo de aplicaciones web con C#", DateCreated = DateTime.Now.AddDays(-10) },
            new Job { Id = "2", Name = "Analista de Sistemas", Description = "Análisis y diseño de sistemas", DateCreated = DateTime.Now.AddDays(-9) },
            new Job { Id = "3", Name = "Arquitecto de Software", Description = "Diseño de arquitecturas escalables", DateCreated = DateTime.Now.AddDays(-8) },
            new Job { Id = "4", Name = "Tester QA", Description = "Pruebas de calidad de software", DateCreated = DateTime.Now.AddDays(-7) },
            new Job { Id = "5", Name = "Product Owner", Description = "Gestión de productos digitales", DateCreated = DateTime.Now.AddDays(-6) },
            new Job { Id = "6", Name = "UX Designer", Description = "Diseño de experiencia de usuario", DateCreated = DateTime.Now.AddDays(-5) },
            new Job { Id = "7", Name = "Data Scientist", Description = "Análisis de datos y machine learning", DateCreated = DateTime.Now.AddDays(-4) },
            new Job { Id = "8", Name = "DevOps Engineer", Description = "Automatización y despliegue continuo", DateCreated = DateTime.Now.AddDays(-3) },
            new Job { Id = "9", Name = "Cybersecurity Specialist", Description = "Seguridad informática y protección", DateCreated = DateTime.Now.AddDays(-2) },
            new Job { Id = "10", Name = "Mobile Developer", Description = "Desarrollo de aplicaciones móviles", DateCreated = DateTime.Now.AddDays(-1) }
        };

        public ActionResult Index()
        {
            return View(_jobs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Job job)
        {
            if (ModelState.IsValid)
            {
                job.Id = (_jobs.Count + 1).ToString();
                job.DateCreated = DateTime.Now;
                _jobs.Add(job);
            }
            return View("Index", _jobs);
        }
    }
}