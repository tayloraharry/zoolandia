namespace Zoolandia.Animals
{
    public class CanisLupusFamiliaris: Canis
    {
        public CanisLupusFamiliaris () 
        {
            this.DetailedCommonName = "Golden Retriever ";
        }
        public override void Speed() {
            this.SpeedMPH = 8;
        }
        public override void Sleep() {
            this.SleepHours = 11;
        }
    }
}