using System;

namespace ProgramacionAvanzada.Web.Models
{
    public class Car
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        public Car()
        {
            DateCreated = DateTime.Now;
        }
    }
}