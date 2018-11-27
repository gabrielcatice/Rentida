using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentidaCar2.Model;
using RentidaCar2.Database;
using System.Data;

namespace RentidaCar2.DAO
{
    class ClientDAO
    {
        public void Create(Client client)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("INSERT INTO rentida.client(fullname, phone_number, client_gender, document_number, birthdate, last_rent_date, status, address_id) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6})",
                client.FullName, client.PhoneNumber, client.ClientGender, client.Document,
                client.BirthDate, client.LastRentDate, client.Status, client.Address.Id);

            rentida.ExecuteNonQuery(query);
        }

        public Client Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.client WHERE id=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            Client client = new Client();

            DataRow dr = ds.Tables[0].Rows[0];
            client.Id = dr["id"].ToString();
            client.FullName = dr["full_name"].ToString();
            client.PhoneNumber = dr["phone_number"].ToString();
            client.ClientGender = Client.Gender.Male;
            client.Document = dr["document"].ToString();
            client.BirthDate = Convert.ToDateTime(dr["birthdate"]);
            client.LastRentDate = Convert.ToDateTime(dr["last_rent_date"]);
            client.Status = Client.ClientStatus.Regular;

            ClientAddressDAO addressDAO = new ClientAddressDAO();
            client.Address = addressDAO.Read(dr["address_id"].ToString());

            return client;
        }

        public void Update(Client client)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("INSERT INTO rentida.client(fullname, phone_number, client_gender, document_number, birthdate, last_rent_date, status, address_id) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6})",
                client.FullName, client.PhoneNumber, client.ClientGender, client.Document,
                client.BirthDate, client.LastRentDate, client.Status, client.Address.Id);

            rentida.ExecuteNonQuery(query);
        }

        public void Delete(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("DELETE from rentida.client WHERE id =" + id);

            rentida.ExecuteNonQuery(query);
        }

        public List<Client> ListAll()
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno";
            DataSet ds = rentida.ExecuteQuery(query);
            List<Client> clientList = new List<Client>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Client client = new Client();
                client.Id = dr["id"].ToString();
                client.FullName = dr["full_name"].ToString();
                client.PhoneNumber = dr["phone_number"].ToString();
                client.ClientGender = Client.Gender.Male;
                client.Document = dr["document"].ToString();
                client.BirthDate = Convert.ToDateTime(dr["birthdate"]);
                client.LastRentDate = Convert.ToDateTime(dr["last_rent_date"]);
                client.Status = Client.ClientStatus.Regular;

                ClientAddressDAO addressDAO = new ClientAddressDAO();
                client.Address = addressDAO.Read(dr["address_id"].ToString());
                clientList.Add(client);
            }
            return clientList;
        }

        public List<Client> FindByName(string modelName)
        {
            List<Client> clientList = new List<Client>();
            return clientList;
        }
    }
}
