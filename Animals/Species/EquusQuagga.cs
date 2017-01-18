namespace Zoolandia.Animals
{
    public class EquusQuagga: Equus
    {
        public EquusQuagga () 
        {
            this.DetailedCommonName = "Zebra";
            this.SignatureNoise = "hnyeahhhh";
            this.FeedingsPerDay = 23;
        }
        public override void Sleep () {
            this.SleepHours = 6;
        }
        public override void Speed () {
            this.SpeedMPH = 29;
        }
    }
}