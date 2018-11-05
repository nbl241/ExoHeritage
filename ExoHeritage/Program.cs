using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //Cat cat = new Cat();
            //Console.WriteLine(dog.Describe());
            //Console.WriteLine(cat.Describe());
            //Console.ReadKey();

            ArrayList animalList = new ArrayList
            {
                new Dog(),
                new Cat()
            };

            foreach (FourLeggedAnimal animal in animalList)
                Console.WriteLine(animal.Describe());
            Console.ReadKey();
        }
    }
}
