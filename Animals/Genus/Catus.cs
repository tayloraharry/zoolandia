using System;

namespace Zoolandia.Animals
{
    public class Catus: Animal
    {
        public Catus () 
        {
            this.CommonName = "Cat";
        }

        public Catus (string myAnimalname)
        {
            this.Name = myAnimalname;
        }
        public Catus (string food, int numberOfFeedings)
        {
            this.FavoriteFood = food;
            this.FeedingsPerDay = numberOfFeedings;
        }
    }
}