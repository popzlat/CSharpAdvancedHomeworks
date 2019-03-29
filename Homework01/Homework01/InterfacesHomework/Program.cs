using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            IPredator shark = new Fish() { AttackSpeed = 30, Name = "Shark" };
            IPray pinguin = new Fish() { FleeSpeed = 25, Name = "Pinguin" };
            IPray herring = new Fish() { FleeSpeed = 35, Name = "Herring" };
            shark.Attack(pinguin);
            shark.Attack(herring);
            Console.WriteLine();
            //---------------------------------

            IPredator gepard = new Cat() { AttackSpeed = 60, Name = "Gepard" } ;
            IPray gazella = new Gazella() { FleeSpeed = 55, Name = "Gazella" };
            IPredator tiger = new Cat() {AttackSpeed = 70,Name = "Tiger"};
            tiger.Attack(pinguin);
            pinguin.Flee();
            gepard.Attack(gazella);
            IPredator lion = new Cat { AttackSpeed = 35, Name = "Lion" };
            lion.Attack(gazella);
            



            Console.ReadLine();
        }
    }
}
