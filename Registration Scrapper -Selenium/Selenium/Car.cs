using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Registration { get; set; }
        public string Mot { get; set; }
        public string Tax { get; set; }

        public Car()
        {
            this.Make = "Unknown";
            this.Color = "Unknown";
            this.Registration = "Unknown"; 
            this.Year = "Unknown";
            this.Mot = "Unknown";
            this.Tax = "Unknown"; 
        }

        public Car(string _registration)
        {
            this.Registration = _registration;
        }
    }
}
