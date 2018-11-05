using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHeritage
{
    //public class Dog : Animal
    //{
    //    public override void Greet()
    //    {
    //        Console.WriteLine("Hello, I'm a dog");
    //    }
    //}

    public class Dog : FourLeggedAnimal
    {
        public override string Describe()
        {
            return "I'm a dog";
        }
    }
}
