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
            var integersSet1 = new Set<int>(1, 2, 3, 3, 3, 4, 5);
            System.Console.WriteLine(integersSet1);
            foreach (var i in integersSet1)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("=== Ordered Pair ===");
            var orderedPair = new OrderedPair<int>(1, 4);
            System.Console.WriteLine(orderedPair);
            System.Console.WriteLine();

            System.Console.WriteLine("=== Cartesian product ===");
            var integersSet2 = new Set<int>(6,7,8,9);
            var cartesianProduct = new CartesianProduct<int>(integersSet1, integersSet2);
            foreach (var pair in cartesianProduct)
            {
                System.Console.WriteLine(pair);
            }
            System.Console.WriteLine();

            System.Console.ReadKey();
        }
    }
}
