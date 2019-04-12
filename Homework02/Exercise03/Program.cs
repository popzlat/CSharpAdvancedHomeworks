using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Action line = () => Console.WriteLine();


            List<int> listOfNumbers = new List<int>();

            listOfNumbers.Add(10);
            listOfNumbers.Add(48);
            listOfNumbers.Add(52);
            listOfNumbers.Add(94);
            listOfNumbers.Add(63);
            listOfNumbers.Add(35);
            listOfNumbers.Add(25);

            Console.WriteLine("Input the number of members on the List : 5 ");
            line();
            //var input = Console.ReadLine();

            // testing if input was 5 
            int input = 5;
            var takes = listOfNumbers.Take(input);

            var counter = 0;

            foreach (var item in takes) {
                Console.WriteLine($" Member {counter} : {item}");
                counter++;
            }

            line();
            // var input2 = Console.ReadLine();
            //Input the value above you want to display the members of the List : 59

            var input2 = 59;

            Console.WriteLine("The numbers greater than 59 are : ");
            line();
            var greater = takes.Where(x => x > input2);

            foreach (var item in greater) {
                Console.WriteLine(item );
            }




            Console.ReadLine();




        }
    }
}
