using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01.StringExtension;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string pharse;
            pharse = "Madam, I'm Adam";
            Console.WriteLine(pharse.IsPalindrom()); //true
            pharse = "Madam, I am Adam";
            Console.WriteLine(pharse.IsPalindrom()); // false
            pharse = "Refer, refer!";
            Console.WriteLine(pharse.IsPalindrom()); // true
            double numeric;
            numeric = 123.321;
            Console.WriteLine(numeric.IsPalindrom()); // true
            int integer;
            integer = 11211;
            Console.WriteLine(integer.IsPalindrom()); // true
            long bigint;
            bigint = 123456654321;
            Console.WriteLine(bigint.IsPalindrom()); // true

            Console.ReadLine();
        }
    }
}
