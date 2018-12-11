using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentidaCar2.Model
{
    public class Vehicle
    {
        private string id;
        private string modelName;
        private Brand carBrand;
        private DateTime releaseYear;
        private int kmAmount;
        private Type carType;
        private bool isRented = false;
        private DateTime lastRentDate;

        public Vehicle(string id, string modelName, Brand carBrand, DateTime releaseYear, int kmAmount, Type carType, bool isRented, DateTime lastRentDate)
        {
            this.id = id;
            this.modelName = modelName;
            this.carBrand = carBrand;
            this.releaseYear = releaseYear;
            this.kmAmount = kmAmount;
            this.carType = carType;
            this.isRented = isRented;
            this.lastRentDate = lastRentDate;
        }

        public Vehicle()
        {
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

        public string ModelName
        {
            get
            {
                return modelName;
            }

            set
            {
                modelName = value;
            }
        }

        internal Brand CarBrand
        {
            get
            {
                return carBrand;
            }

            set
            {
                carBrand = value;
            }
        }

        public DateTime ReleaseYear
        {
            get
            {
                return releaseYear;
            }

            set
            {
                releaseYear = value;
            }
        }

        public int KmAmount
        {
            get
            {
                return kmAmount;
            }

            set
            {
                kmAmount = value;
            }
        }

        internal Type CarType
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

        public bool IsRented
        {
            get
            {
                return isRented;
            }

            set
            {
                isRented = value;
            }
        }

        public DateTime LastRentDate
        {
            get
            {
                return lastRentDate;
            }

            set
            {
                lastRentDate = value;
            }
        }

        public enum Brand: int
        {
            Chevrolet = 1,
            Volkswagen = 2,
            Ford = 3,
            Fiat = 4
        }

        public enum Type: int
        {
            Simple = 1,
            Complete = 2,
            Premmium = 3
        }
    }
}
