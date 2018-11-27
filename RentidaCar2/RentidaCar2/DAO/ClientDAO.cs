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
            string query = string.Format("", client.Id);

            rentida.ExecuteNonQuery(query);
        }

        public Client Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno WHERE cpf=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            Client client = new Client();

            DataRow dr = ds.Tables[0].Rows[0];
            client.Id = dr["id"].ToString();

            return client;
        }

        public void Update(Client car)
        {

        }

        public void Delete(string id)
        {

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
