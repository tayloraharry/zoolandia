namespace Zoolandia.Animals
{
    public class EquusFerusCaballus: Equus
    {
        public EquusFerusCaballus () 
        {
            this.DetailedCommonName = "stallion";
            this.SignatureNoise = "nayyyy";
            this.FeedingsPerDay = 5;
        }
        public override void Sleep () {
            this.SleepHours = 5;
        }
        public override void Speed () {
            this.SpeedMPH = 40;
        }
        public override void Cuteness () {
            this.CutenessFactor = 8;
        }

    }
}