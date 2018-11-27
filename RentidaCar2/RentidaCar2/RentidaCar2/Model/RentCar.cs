using System;

namespace RentidaCar2.Model
{
    public class RentCar
    {
        private string id;
        private Client renter;
        private RentPlan rentPlan;
        private Vehicle renterVehicle;
        private DateTime rentDate;
        private DateTime devolutionDate;
        private Payment paymentMethod;
        private double initialValue;
        private double totalValue;
        private RentStatus status;
        private bool isPaid = false;

        public RentCar(string id, Client renter, RentPlan rentPlan, Vehicle renterVehicle, DateTime rentDate, DateTime devolutionDate, Payment paymentMethod, double initialValue, double totalValue, RentStatus status, bool isPaid)
        {
            this.id = id;
            this.renter = renter;
            this.rentPlan = rentPlan;
            this.renterVehicle = renterVehicle;
            this.rentDate = rentDate;
            this.devolutionDate = devolutionDate;
            this.paymentMethod = paymentMethod;
            this.initialValue = initialValue;
            this.totalValue = totalValue;
            this.status = status;
            this.isPaid = isPaid;
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

        internal Client Renter
        {
            get
            {
                return renter;
            }

            set
            {
                renter = value;
            }
        }

        internal RentPlan RentPlan
        {
            get
            {
                return rentPlan;
            }

            set
            {
                rentPlan = value;
            }
        }

        internal Vehicle RenterVehicle
        {
            get
            {
                return renterVehicle;
            }

            set
            {
                renterVehicle = value;
            }
        }

        public DateTime RentDate
        {
            get
            {
                return rentDate;
            }

            set
            {
                rentDate = value;
            }
        }

        public DateTime DevolutionDate
        {
            get
            {
                return devolutionDate;
            }

            set
            {
                devolutionDate = value;
            }
        }

        internal Payment PaymentMethod
        {
            get
            {
                return paymentMethod;
            }

            set
            {
                paymentMethod = value;
            }
        }

        public double InitialValue
        {
            get
            {
                return initialValue;
            }

            set
            {
                initialValue = value;
            }
        }

        public double TotalValue
        {
            get
            {
                return totalValue;
            }

            set
            {
                totalValue = value;
            }
        }

        internal RentStatus Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public bool IsPaid
        {
            get
            {
                return isPaid;
            }

            set
            {
                isPaid = value;
            }
        }

        public enum RentStatus
        {
            Open = 1,
            Running = 2,
            Finished = 3
        }
    }
}
