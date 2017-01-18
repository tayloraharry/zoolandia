using System;

namespace Zoolandia.Animals
{
    public class Canis: Animal
    {
        public Canis () 
        {
            this.CommonName = "Dog";
        }

        public Canis (string myAnimalname)
        {
            this.Name = myAnimalname;
        }
        public Canis (string food, int numberOfFeedings)
        {
            this.FavoriteFood = food;
            this.FeedingsPerDay = numberOfFeedings;
        }
    }
}