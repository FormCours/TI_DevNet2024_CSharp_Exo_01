using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo07_2.Models
{
    public struct Equation
    {
        public double A;
        public double B;
        public double C;

        public bool Resoudre(out double? X1, out double? X2)
        {
            double delta = Math.Pow(B, 2) - 4 * A * C;
            bool success = false;

            X1 = null;
            X2 = null;

            if (delta >= 0)
            {
                X1 = (-B + Math.Sqrt(delta)) / (2 * A);
                X2 = (-B - Math.Sqrt(delta)) / (2 * A);
                success = true;
            }

            return success;
        }
    }
}
