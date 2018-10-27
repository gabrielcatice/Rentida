using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentidaCar2.Model
{
    class ClientAddress
    {
        private string id;
        private AddressType clientAddressType;
        private string adddressName;
        private string addressNumber;
        private string neighbourhood;
        private string zipCode;
        private string city;
        private string state;
        private string country;

        public ClientAddress(string id, AddressType clientAddressType, string adddressName, string addressNumber, string neighbourhood, string zipCode, string city, string state, string country)
        {
            this.id = id;
            this.clientAddressType = clientAddressType;
            this.adddressName = adddressName;
            this.addressNumber = addressNumber;
            this.neighbourhood = neighbourhood;
            this.zipCode = zipCode;
            this.city = city;
            this.state = state;
            this.country = country;
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

        internal AddressType ClientAddressType
        {
            get
            {
                return clientAddressType;
            }

            set
            {
                clientAddressType = value;
            }
        }

        public string AdddressName
        {
            get
            {
                return adddressName;
            }

            set
            {
                adddressName = value;
            }
        }

        public string AddressNumber
        {
            get
            {
                return addressNumber;
            }

            set
            {
                addressNumber = value;
            }
        }

        public string Neighbourhood
        {
            get
            {
                return neighbourhood;
            }

            set
            {
                neighbourhood = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }

            set
            {
                zipCode = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public enum AddressType
        {
            Street = 1,
            Avenue = 2,
            Road = 3
        }
    }
}
