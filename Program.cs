using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myAnimal = new EquusFerusCaballus();
            myAnimal.Sleep();
            myAnimal.Speed();
            myAnimal.Cuteness();
            Console.WriteLine("Common Name: " + myAnimal.CommonName);
            Console.WriteLine("Cuteness Factor: " + myAnimal.CutenessFactor);
            Console.WriteLine("Detailed Common Name: " + myAnimal.DetailedCommonName);
            Console.WriteLine("Favorite Food: " + myAnimal.FavoriteFood);
            Console.WriteLine("Feedings Per Day: " + myAnimal.FeedingsPerDay);
            Console.WriteLine("Name: " + myAnimal.Name);
            Console.WriteLine("Signature Noise: \"" + myAnimal.SignatureNoise + "\"");
            Console.WriteLine("Sleep Hours: " + myAnimal.SleepHours +" hours per day");
            Console.WriteLine("Speed MPH: " + myAnimal.SpeedMPH + " mph");
        }
    }
}
