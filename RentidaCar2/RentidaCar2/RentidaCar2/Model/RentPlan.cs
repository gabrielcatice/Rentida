namespace RentidaCar2.Model
{
    public class RentPlan
    {
        private string id;
        private string planName;
        private double baseValue;
        private int starterKm;
        private double additionalValue;
        private double dailyValue;
        private Vehicle.Type carType;

        public RentPlan(string id, string planName, double baseValue, int starterKm, double additionalValue, double dailyValue, Vehicle.Type carType)
        {
            this.id = id;
            this.planName = planName;
            this.baseValue = baseValue;
            this.starterKm = starterKm;
            this.additionalValue = additionalValue;
            this.dailyValue = dailyValue;
            this.carType = carType;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string PlanName
        {
            get
            {
                return planName;
            }

            set
            {
                planName = value;
            }
        }

        public double BaseValue
        {
            get
            {
                return baseValue;
            }

            set
            {
                baseValue = value;
            }
        }

        public int StarterKm
        {
            get
            {
                return starterKm;
            }

            set
            {
                starterKm = value;
            }
        }

        public double AdditionalValue
        {
            get
            {
                return additionalValue;
            }

            set
            {
                additionalValue = value;
            }
        }

        public double DailyValue
        {
            get
            {
                return dailyValue;
            }

            set
            {
                dailyValue = value;
            }
        }

        internal Vehicle.Type CarType
        {
            get
            {
                return carType;
            }

            set
            {
                carType = value;
            }
        }
    }
}
