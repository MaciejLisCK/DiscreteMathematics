using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscreteMathematics.BusinessLogic;

namespace DiscreteMathematics.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("=== Set ===");

            var integersSet = new Set<int>(1, 2, 3, 3, 3, 4, 5);
            System.Console.WriteLine(integersSet);

            foreach (var i in integersSet)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("=== Ordered Pair ===");

            var orderedPair = new OrderedPair<int>(1, 4);
            System.Console.WriteLine(orderedPair);



            System.Console.ReadKey();
        }
    }
}
