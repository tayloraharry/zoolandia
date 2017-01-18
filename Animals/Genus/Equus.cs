using System;

namespace Zoolandia.Animals
{
    public class Equus: Animal
    {
        public Equus () 
        {
            this.CommonName = "horse";
        }
        public Equus (string myAnimalname)
        {
            this.Name = myAnimalname;
        }
        public Equus (string food, int numberOfFeedings)
        {
            this.FavoriteFood = food;
            this.FeedingsPerDay = numberOfFeedings;
        }
    }
}