namespace BeeHiveManagement
{
    class Bee : IStingPatrol
    {
        public const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg { get; private set; }

        private int alertLevel = 5; // { get ; }

        public int AlertLevel 
        {
            get {
                return alertLevel; 
                }
        }

        private int stingerLength;
        public int StingerLength { get => stingerLength; set => stingerLength = value; }
        
        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return length;
        }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}