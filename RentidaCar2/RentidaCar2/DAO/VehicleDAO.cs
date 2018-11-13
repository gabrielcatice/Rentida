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
    class VehicleDAO
    {
        public void Create(Vehicle car)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("", car.Id);

            rentida.ExecuteNonQuery(query);
        }

        public Vehicle Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno WHERE cpf=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            Vehicle car = new Vehicle();

            DataRow dr = ds.Tables[0].Rows[0];
            car.Id = dr["id"].ToString();

            return car;
        }

        public void Update(Vehicle car)
        {

        }

        public void Delete(string id)
        {

        }

        public List<Vehicle> ListAll()
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno";
            DataSet ds = rentida.ExecuteQuery(query);
            List<Vehicle> carList = new List<Vehicle>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Vehicle car = new Vehicle();
                car.Id = dr["id"].ToString();
                carList.Add(car);
            }
            return carList;
        }

        List<Vehicle> FindByModelName(string modelName)
        {
            List<Vehicle> carList = new List<Vehicle>();
            return carList;
        }

    }
}
