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
            var integersSet = new Set<int>(1, 2, 3, 3, 3, 4, 5);

            foreach (var i in integersSet)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("===");

            foreach (var i in integersSet)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("===");

            foreach (var i in integersSet)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("===");

            System.Console.ReadKey();
        }
    }
}
