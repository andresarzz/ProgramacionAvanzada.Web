using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProgramacionAvanzada.Web.Models;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class CarController : Controller
    {
        private static List<Car> _cars = new List<Car>
        {
            new Car { Id = "1", Name = "Toyota Corolla", Description = "Sedán compacto confiable", DateCreated = DateTime.Now.AddDays(-10) },
            new Car { Id = "2", Name = "Honda Civic", Description = "Automóvil deportivo elegante", DateCreated = DateTime.Now.AddDays(-9) },
            new Car { Id = "3", Name = "Ford Mustang", Description = "Muscle car americano clásico", DateCreated = DateTime.Now.AddDays(-8) },
            new Car { Id = "4", Name = "BMW Serie 3", Description = "Sedán de lujo alemán", DateCreated = DateTime.Now.AddDays(-7) },
            new Car { Id = "5", Name = "Audi A4", Description = "Vehículo premium con tecnología", DateCreated = DateTime.Now.AddDays(-6) },
            new Car { Id = "6", Name = "Mercedes-Benz C-Class", Description = "Elegancia y performance", DateCreated = DateTime.Now.AddDays(-5) },
            new Car { Id = "7", Name = "Volkswagen Jetta", Description = "Sedán familiar eficiente", DateCreated = DateTime.Now.AddDays(-4) },
            new Car { Id = "8", Name = "Nissan Altima", Description = "Comodidad y economía", DateCreated = DateTime.Now.AddDays(-3) },
            new Car { Id = "9", Name = "Hyundai Elantra", Description = "Diseño moderno y garantía", DateCreated = DateTime.Now.AddDays(-2) },
            new Car { Id = "10", Name = "Mazda 6", Description = "Conducción deportiva refinada", DateCreated = DateTime.Now.AddDays(-1) }
        };

        public ActionResult Index()
        {
            return View(_cars);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                car.Id = (_cars.Count + 1).ToString();
                car.DateCreated = DateTime.Now;
                _cars.Add(car);
            }
            return View("Index", _cars);
        }
    }
}