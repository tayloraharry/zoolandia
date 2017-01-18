namespace Zoolandia.Animals
{
    public class CanisLuposFamiliaris: Canis
    {
        public CanisLuposFamiliaris () 
        {
            this.DetailedCommonName = "Black Lab";
        }
        public override void Speed() {
            this.SpeedMPH = 9;
        }
        public override void Sleep() {
            this.SleepHours = 10;
        }
    }
}