using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insect
{
    internal class Player
    {
        public string Name { get; set; }

        public int Age;

        public string Height { get; set; }

        public void AdoptsInsect()
        {
            Console.WriteLine(Name + " adopts the spider!");
        }

        public void GivesName()
        {
            Console.WriteLine(Name + " names him Jumper!");
        }

        public void Eat()
        {
            Console.WriteLine(Name + " eats.");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " sleeps.");
        }

        public void Grow()
        {
            Console.WriteLine(Name + " grows up!");
        }

        public void Walk()
        {
            Console.WriteLine(Name + " walks.");
        }
    }
}

//Adelle Raymond, Malik Allen, Jack, Ismael Gonzalez, Juan Ocegueda, Gianna Dimperio}
