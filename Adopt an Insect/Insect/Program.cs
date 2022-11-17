using System;
using System.Xml.Linq;

namespace Insect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insect1 Jumper = new Insect1();
            Jumper.ScientificName = "Phidippus putnami";
            Jumper.PersonalName = "Jumper";
            Jumper.Type = "arachnid";
            Jumper.Food = "flies";
            Jumper.Color = "black and white";
            Jumper.Sound = "boooiing";
            Jumper.Lifespan = 1;
            Jumper.UniqueTrait = "jumping";
            Jumper.Eat();
            Jumper.UsesTrait();
            Jumper.Grow();
            Jumper.Sleep();
            Jumper.MakeNoise();
            Jumper.Walk();

            Player Oscar = new Player();
            Oscar.Name = "Oscar";
            Oscar.Age = 19;
            Oscar.Height = "5'5";
            Oscar.AdoptsInsect();
            Oscar.GivesName();
            Oscar.Eat();
            Oscar.Sleep();
            Oscar.Grow();
            Oscar.Walk();

            Habitat SpiderJail = new Habitat();
            SpiderJail.Name = "Spider Jail";
            SpiderJail.Environment = "Temperate Forest";
            SpiderJail.Temperature = 75;
            SpiderJail.Size = "4x5 sq feet";
            SpiderJail.Percipitation = false;
            SpiderJail.Material = "Glass";
            SpiderJail.ChangesTemp();

        }
        
    }
}

//Adelle Raymond, Malik Allen, Jack, Ismael Gonzalez, Juan Ocegueda, Gianna Dimperio}