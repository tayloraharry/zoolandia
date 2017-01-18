namespace Zoolandia.Animals
{
    public class FelosCatus: Catus
    {
        public FelosCatus () 
        {
            this.DetailedCommonName = "Orange Cat";
            this.SignatureNoise = "mmeeeoooOOOWWWW";
            this.FavoriteFood = "tuna";
        }
        public override void Sleep ()
        {
            this.SleepHours = 20;
        }
        public override void Speed () 
        {
            this.SpeedMPH = 4;
        }
    }
}