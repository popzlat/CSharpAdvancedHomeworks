using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "apple";

            var frequency = input.GroupBy(p => p);
            Console.WriteLine($"The frequency of the characters {input} are : ");
            foreach (var character in frequency) {
                Console.WriteLine($"Character {character.Key} : {character.Count()} times ");
                
            }

            Console.ReadLine();



        }
    }
}
