using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 9,5,5,9,1,5};

            var str = string.Join("", numbers);

            var groupNumbers = str.GroupBy(x => x);

            Console.WriteLine($"The number and the Frequency in {str} are : ");
            foreach (var num in groupNumbers) {
                
                Console.WriteLine($"Number {num.Key} appears {num.Count()} times ");

            }

            
            Console.ReadLine();


        }
    }
}
