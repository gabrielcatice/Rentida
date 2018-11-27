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
            car.KmAmount = Convert.ToInt16(dr["km_count"].ToString());
            car.CarType = Vehicle.Type.Premmium;
            car.IsRented = Convert.ToBoolean(dr["is_rented"].ToString());
            car.LastRentDate = Convert.ToDateTime(dr["_last_rent_date"].ToString());

            return car;
        }

        public void Update(Vehicle car)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("UPDATE rentida.vehicle SET model_name='{0}', brand='{1}', release_year='{2}', km_count='{3}', car_type='{4}', is_rented='{5}', last_rent_date='{6}'" + "WHERE id ='{7}'",
                car.ModelName, car.CarBrand, car.ReleaseYear, car.KmAmount, car.CarType, car.IsRented, car.LastRentDate, car.Id);

            rentida.ExecuteNonQuery(query);
        }

        public void Delete(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("DELETE from rentida.vehicle WHERE id =" + id);

            rentida.ExecuteNonQuery(query);
        }

        public List<Vehicle> ListAll()
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM vehicle";
            DataSet ds = rentida.ExecuteQuery(query);
            List<Vehicle> carList = new List<Vehicle>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Vehicle car = new Vehicle();
                car.Id = dr["id"].ToString();
                car.ModelName = dr["model_name"].ToString();
                car.CarBrand = Vehicle.Brand.Chevrolet;
                car.ReleaseYear = Convert.ToDateTime(dr["release_year"].ToString());
                car.KmAmount = Convert.ToInt16(dr["km_count"].ToString());
                car.CarType = Vehicle.Type.Premmium;
                car.IsRented = Convert.ToBoolean(dr["is_rented"].ToString());
                car.LastRentDate = Convert.ToDateTime(dr["_last_rent_date"].ToString());
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
