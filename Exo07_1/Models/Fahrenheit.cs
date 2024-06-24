using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo07_1.Models
{
    public struct Fahrenheit
    {
        public double Temperature;

        public Celsius ToCelsius() 
        {
            Celsius c;

            c.Temperature = Math.Round((Temperature - 32) / 1.8, 2);

            return c;
        }
    }
}
