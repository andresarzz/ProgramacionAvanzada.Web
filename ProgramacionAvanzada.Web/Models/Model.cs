using System;

namespace ProgramacionAvanzada.Web.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        public Person()
        {
            DateCreated = DateTime.Now;
        }
    }
}