namespace Zoolandia.Animals
{
    public class FelisCatus: Catus
    {
        public FelisCatus () 
        {
            this.DetailedCommonName = "Tabby Cat";
            this.SignatureNoise = "mmeeeoooOOOWWWW";
            this.FavoriteFood = "salmon";
        }
        public override void Sleep ()
        {
            this.SleepHours = 18;
        }
        public override void Speed () 
        {
            this.SpeedMPH = 6;
        }
    }
}