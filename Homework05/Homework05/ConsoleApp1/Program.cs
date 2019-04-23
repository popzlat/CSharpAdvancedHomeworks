using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("igor", "partizanska 95", "Skopje", 30000);
            Customer c2 = new Customer("dejan", "roza luxemburg 1", "Skopje", 25000);
            Customer c3 = new Customer("ivan", "partizanska 95", "Strumica", 29000);
            Customer c5 = new Customer("petar", "vodjanska 95", "Bitola", 35000);
            Customer c6 = new Customer("igor", "partizanska 95", "Skopje", 30000);

            Customer[] customers = new Customer[] { c1, c2, c3, c5, c5 };

            
            Console.WriteLine("Equality c1 and c5 {0}", c1.Equals(c5));

            if (c1 == c5) {
                Console.WriteLine("c1 == c5");
            }
            else
                Console.WriteLine("c1 != c5");

            Console.WriteLine(c1 == c6);
            
            Console.ReadLine();
        }
    }
}
