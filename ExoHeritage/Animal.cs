using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHeritage
{
    public class Animal
    {
        public int Age { get; set; }

        public string Nom { get; set; }

        public string Race { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine("Hellol, I'm some sort of animal");
        }
    }
}
