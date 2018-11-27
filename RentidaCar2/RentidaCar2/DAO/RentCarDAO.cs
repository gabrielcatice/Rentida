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
    class RentCarDAO
    {
        public void Create(RentCar renting)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("", renting);

            rentida.ExecuteNonQuery(query);
        }

        public RentCar Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno WHERE cpf=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            RentCar renting = new RentCar();

            DataRow dr = ds.Tables[0].Rows[0];

            return renting;
        }

        public void Update(RentCar renting)
        {

        }

        public void Delete(string id)
        {

        }
    }
}
