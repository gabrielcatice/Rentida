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
        public void Create(RentidaCar2.Model.RentCar renting)
        {
            /*   (`id`,
`client_id`,
`vehicle_id`,
`plan_id`,
`payment_method`,
`rent_date`,
`devolution_date`,
`initial_value`,
`total_value`,
`status`,
`is_paid */
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("INSERT INTO rentida.rent_car(client_id, vehicle_id, plan_id, payment_method, rent_date, devolution_date, initial_value, total_value, status, is_paid) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6}', '{7}', '{8}', '{9}')",
                renting.Renter.Id, renting.RenterVehicle.Id, renting.RentPlan.Id, renting.PaymentMethod.Id,
                renting.RentDate, renting.DevolutionDate, renting.InitialValue, renting.TotalValue,
                renting.Status, renting.IsPaid);

            rentida.ExecuteNonQuery(query);
        }

        public Model.RentCar Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.rent_car WHERE id=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            Model.RentCar renting = new Model.RentCar();

            DataRow dr = ds.Tables[0].Rows[0];

            ClientDAO client = new ClientDAO();
            VehicleDAO car = new VehicleDAO();
            RentPlanDAO plan = new RentPlanDAO();


            renting.Renter = client.Read(dr["client_id"].ToString());



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
