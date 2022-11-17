using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insect
{
    internal class Habitat
    {
        public string Name { get; set; }

        public string Environment { get; set; }

        public int Temperature;

        public string Size { get; set; }

        public bool Percipitation;

        public string Material { get; set; }

        public void ChangesTemp()
        {
            Console.WriteLine(Name + " climate adjusts to better suit Jumper's needs.");
        }

    }
}
