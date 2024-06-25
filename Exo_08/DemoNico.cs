using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_08
{
    public struct DemoNico
    {
        /// <summary>
        /// Explication de la méthode Random.Shared.Shuffle(...) par Nicolas Gihoul.
        /// </summary>
        public void NicoExplique()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Initial : {string.Join(" > ", numbers)}");

            Random.Shared.Shuffle(numbers);
            Console.WriteLine($"Random : {string.Join(" > ", numbers)}");

            /*
             { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }

                random (1, 10) = 5
             { 4, 1, 2, 3, 0, 5, 6, 7, 8, 9 }
               _ 
                random (2, 10) = 2
             { 4, 1, 2, 3, 0, 5, 6, 7, 8, 9 }
               _  _ 
                random (3, 10) = 6
             { 4, 1, 5, 3, 0, 2, 6, 7, 8, 9 }
               _  _  _
                random (4, 10) = 10
             { 4, 1, 5, 9, 0, 2, 6, 7, 8, 3 }
               _  _  _  _

             etc.
             */
        }
    }
}
