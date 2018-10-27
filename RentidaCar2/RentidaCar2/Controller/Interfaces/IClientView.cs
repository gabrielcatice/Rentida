using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentidaCar2.Model;

namespace RentidaCar2.Controller.Interfaces
{
    public interface IClientView
    {
        void SetController(ClientController controller);
        void CreateClient(Client client);
        void UpdateClient(Client client);
        void RemoveClient(int clientId);
        void ClearGrid();

        string Id { get; set; }
        string FullName { get; set; }
        string PhoneNumber { get; set; }
        ClientAddress Address { get; set; }
        Client.Gender Gender { get; set; }
        string Document { get; set; }
        DateTime BirthDate { get; set; }
        DateTime LastRentDate { get; set; }
        Client.ClientStatus Status { get; set; }
    }
}
