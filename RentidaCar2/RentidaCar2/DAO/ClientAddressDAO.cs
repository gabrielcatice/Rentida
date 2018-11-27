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
    class ClientAddressDAO
    {
        public void Create(ClientAddress client)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("", client.Id);

            rentida.ExecuteNonQuery(query);
        }

        public ClientAddress Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno WHERE cpf=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            ClientAddress address = new ClientAddress();

            DataRow dr = ds.Tables[0].Rows[0];
            address.Id = dr["id"].ToString();

            return address;
        }

        public void Update(ClientAddress address)
        {

        }

        public void Delete(string id)
        {

        }
    }
}
