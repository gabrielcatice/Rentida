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
        public void Create(ClientAddress address)
        {
            ClientAddress check = new ClientAddress();
            check = this.Read(address.Id);
            if (check != null)
            {
                System.InvalidOperationException error = new InvalidOperationException();
                throw error;
            }
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("INSERT INTO rentida.client_address(address_type, address_name, address_number, neighbourhood, zip_code, city, state, country) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                 address.ClientAddressType, address.AdddressName, address.AddressNumber, address.Neighbourhood, address.ZipCode, address.City, address.State, address.Country);

            rentida.ExecuteNonQuery(query);
        }

        public ClientAddress Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.client_address WHERE id=" + Convert.ToInt16(id);
            DataSet ds = rentida.ExecuteQuery(query);
            ClientAddress address = new ClientAddress();

            DataRow dr = ds.Tables[0].Rows[0];
            address.Id = dr["id"].ToString();
            switch (Convert.ToInt16(dr["address_type"].ToString()))
            {
                case 1:
                    address.ClientAddressType = ClientAddress.AddressType.Street;
                    break;
                case 2:
                    address.ClientAddressType = ClientAddress.AddressType.Avenue;
                    break;
                case 3:
                    address.ClientAddressType = ClientAddress.AddressType.Road;
                    break;

                default:
                    break;
            }
            
            address.AdddressName = dr["address_name"].ToString();
            address.AddressNumber = dr["address_number"].ToString();
            address.Neighbourhood = dr["neighbourhood"].ToString();
            address.ZipCode = dr["zip_code"].ToString();
            address.City = dr["city"].ToString();
            address.State = dr["state"].ToString();
            address.Country = dr["country"].ToString();

            return address;
        }

        public void Update(ClientAddress address)
        {
            ClientAddress check = new ClientAddress();
            check = this.Read(address.Id);
            if (check != null)
            {
                System.InvalidOperationException error = new InvalidOperationException();
                throw error;
            }
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("UPDATE rentida.client_address SET address_type='{0}', address_name='{1}', address_number='{2}', neighbourhood='{3}', zip_code='{4}', city='{5}', state='{6}', country='{7}'" + "WHERE id ='{7}'",
                 address.ClientAddressType, address.AdddressName, address.AddressNumber, address.Neighbourhood, address.ZipCode, address.City, address.State, address.Country, Convert.ToInt16(address.Id));

            rentida.ExecuteNonQuery(query);
        }

        public void Delete(string id)
        {
            try
            {
                Database.Database rentida = Database.Database.GetInstance();
                string query = string.Format("DELETE from rentida.client_address WHERE id =" + Convert.ToInt16(id));

                rentida.ExecuteNonQuery(query);
            }
            catch (System.ArgumentException)
            {
                System.ArgumentException error = new ArgumentException();
                throw error;
            }
            
        }
    }
}
