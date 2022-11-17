using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insect
{
    internal class Insect1
    {
        public string ScientificName { get; set; }

        public string PersonalName { get; set; }

        public string Type { get; set; }

        public string Food { get; set; }

        public string Color { get; set; }

        public string Sound { get; set; }

        public int Lifespan;

        public string UniqueTrait { get; set; }


        public void Eat()
        {
            Console.WriteLine(PersonalName + " eats.");
        }

        public void UsesTrait()
        {
            Console.WriteLine(PersonalName + " jumps!");
        }

        public void Grow()
        {
            Console.WriteLine(PersonalName + " grows!");
        }

        public void Sleep()
        {
            Console.WriteLine(PersonalName + " sleeps.");
        }

        public void MakeNoise()
        {
            Console.WriteLine(PersonalName + " goes booooinng.");
        }

        public void Walk()
        {
            Console.WriteLine(PersonalName + " walks.");
        }

    }
}

//Adelle Raymond, Malik Allen, Jack, Ismael Gonzalez, Juan Ocegueda, Gianna Dimperio}
