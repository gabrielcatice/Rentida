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
            string query = string.Format("INSERT INTO rentida.vehicle(model_name, brand, release_year, km_count, car_type, is_rented, last_rent_date) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                car.ModelName, car.CarBrand, car.ReleaseYear, car.KmAmount, car.CarType, car.IsRented, car.LastRentDate);

            rentida.ExecuteNonQuery(query);
        }

        public Vehicle Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.vehicle WHERE id=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            Vehicle car = new Vehicle();

            DataRow dr = ds.Tables[0].Rows[0];

            car.Id = dr["id"].ToString();
            car.ModelName = dr["model_name"].ToString();
            car.CarBrand = Vehicle.Brand.Chevrolet;
            car.ReleaseYear = Convert.ToDateTime(dr["release_year"].ToString());
            car.KmAmount = Convert.ToInt16(dr["model_name"].ToString());
            car.CarType = Vehicle.Type.Premmium;
            car.IsRented = Convert.ToBoolean(dr["model_name"].ToString());
            car.LastRentDate = Convert.ToDateTime(dr["model_name"].ToString());

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
                car.ModelName = dr["model_name"].ToString();
                car.CarBrand = Vehicle.Brand.Chevrolet;
                car.ReleaseYear = Convert.ToDateTime(dr["release_year"].ToString());
                car.KmAmount = Convert.ToInt16(dr["model_name"].ToString());
                car.CarType = Vehicle.Type.Premmium;
                car.IsRented = Convert.ToBoolean(dr["model_name"].ToString());
                car.LastRentDate = Convert.ToDateTime(dr["model_name"].ToString());
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
