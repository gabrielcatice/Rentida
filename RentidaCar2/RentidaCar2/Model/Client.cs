using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentidaCar2.Model
{
    class Client
    {
        private string id;
        private string fullName;
        private string phoneNumber;
        private ClientAddress address;
        private Gender clientGender;
        private string document;
        private DateTime birthDate;
        private DateTime lastRentDate;
        private ClientStatus status;

        public Client(string id, string fullName, string phoneNumber, ClientAddress address, Gender clientGender, string document, DateTime birthDate, DateTime lastRentDate, ClientStatus status)
        {
            this.id = id;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.clientGender = clientGender;
            this.document = document;
            this.birthDate = birthDate;
            this.lastRentDate = lastRentDate;
            this.status = status;
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

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        internal ClientAddress Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        internal Gender ClientGender
        {
            get
            {
                return clientGender;
            }

            set
            {
                clientGender = value;
            }
        }

        public string Document
        {
            get
            {
                return document;
            }

            set
            {
                document = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
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

        internal ClientStatus Status
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

        public enum ClientStatus
        {
            Regular = 1,
            Blocked = 2
        }

        public enum Gender
        {
            Male = 1,
            Female = 2
        }
    }
}
