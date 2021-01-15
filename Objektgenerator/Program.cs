using Cage.Classes;
using Objektgenerator.Classes;
using System;
using System.Collections.Generic;

namespace Objektgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe Objektgenerator");

            Objectgenerator objectgenerator = new Objectgenerator();

            var car = objectgenerator.GetNewObject<Car>();

            var cars = objectgenerator.GetNewObjects<Car>(7);

            var tiger = objectgenerator.GetNewObject<Tiger>();

            var tigers = objectgenerator.GetNewObjects<Tiger>(17);

            var monkeys = objectgenerator.GetNewObjects<Monkey>(5);

            var monkey = objectgenerator.GetNewObjectAnimal<Monkey>(); // Car geht nicht, da es nicht von Animal erbt. Tiger und Monkey sind möglich

            var tigersWithName = objectgenerator.GetAnimalsWithName<Tiger>(new object[] { "Johannes", "Emma", "Helga", "Lukas" });

        }
    }
}
