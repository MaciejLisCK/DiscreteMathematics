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
            var relation1 = new Relation<int>(new[]
            {
                new OrderedPair<int>(1, 1),
                new OrderedPair<int>(2, 2),
                new OrderedPair<int>(3, 3),
            });
            var relation2 = new Relation<int>(new[]
            {
                new OrderedPair<int>(1, 2),
                new OrderedPair<int>(3, 2),
            });
            var relation3 = new Relation<int>(new[]
            {
                new OrderedPair<int>(1, 2),
                new OrderedPair<int>(2, 1),
                new OrderedPair<int>(3, 1),
                new OrderedPair<int>(1, 3),
            });
            var relation4 = new Relation<int>(new[]
            {
                new OrderedPair<int>(1, 2),
                new OrderedPair<int>(3, 1),
                new OrderedPair<int>(2, 3),
            });
            var relation5 = new Relation<int>(new[]
            {
                new OrderedPair<int>(1, 1),
                new OrderedPair<int>(2, 2),
            });
            var relation6 = new Relation<int>(new[]
            {
                new OrderedPair<int>(1, 2),
                new OrderedPair<int>(2, 3),
                new OrderedPair<int>(1, 3),
            });
            var relation7 = new Relation<int>(new[]
            {
                new OrderedPair<int>(1, 3),
                new OrderedPair<int>(2, 1),
                new OrderedPair<int>(2, 3),
                new OrderedPair<int>(3, 4),
                new OrderedPair<int>(4, 2),
                new OrderedPair<int>(4, 1),
            });




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
