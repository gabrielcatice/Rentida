using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentidaCar2.Controller.Interfaces;
using RentidaCar2.Model;

namespace RentidaCar2.Controller
{
    public class ClientController
    {
        Client client;
        IClientView view;

        public ClientController(IClientView view)
        {
            this.view = view;
        }

        public void LoadView()
        {
            view.ClearGrid();
        }

        public void AddNewClient()
        {
            ClientAddress address = new ClientAddress("1",
                ClientAddress.AddressType.Street,
                "Rua Bla",
                "233",
                "Jd bl",
                "zipCode",
                "city",
                "state",
                "country");

            DateTime birthdate = new DateTime();
            DateTime lastRentDate = new DateTime();


            client = new Client("43042965821",
                "Gabriel Catice",
                "16997993039",
                address,
                Client.Gender.Male,
                birthdate,
                lastRentDate, 
                Client.ClientStatus.Regular);
        }
        
    }
}
