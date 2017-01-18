using System;

namespace Zoolandia.Animals
{
    public class Animal: IAnimal
    {
        public string Name { get; set; }
        public string SignatureNoise { get; set; }
        public int CutenessFactor { get; set; }
        public string CommonName { get; set;}
        public string DetailedCommonName { get; set;}
        public string FavoriteFood { get; set;}
        public int FeedingsPerDay { get; set;}
        public int SleepHours { get; set;}
        public int SpeedMPH {get; set;}
        public virtual void Sleep ()
        {
            this.SleepHours = 12;
        }
        public virtual void Speed () 
        {
            this.SpeedMPH = 5;
        }
        public virtual void Cuteness () 
        {
            this.CutenessFactor = 5;
        }

        bool IAnimal.Eats()
        {
            return true;
        }

        void IAnimal.Hunt()
        {
            Console.WriteLine("LET'S EATTTTT!!!!");
        }
    }
}