﻿using System;
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
        public void Create(Model.RentCar renting)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("INSERT INTO rentida.rent_car(client_id, vehicle_id, plan_id, payment_method, rent_date, devolution_date, initial_value, total_value, status, is_paid) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6}', '{7}', '{8}', '{9}')",
                renting.Renter.Id, renting.RenterVehicle.Id, renting.RentPlan.Id, renting.PaymentMethod.Id,
                renting.RentDate, renting.DevolutionDate, renting.InitialValue, renting.TotalValue,
                (int) renting.Status, renting.IsPaid);

            rentida.ExecuteNonQuery(query);
        }

        public Model.RentCar Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.rent_car WHERE id=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            Model.RentCar rent = new Model.RentCar();

            DataRow dr = ds.Tables[0].Rows[0];

            rent.Id = dr["id"].ToString();

            ClientDAO client = new ClientDAO();
            rent.Renter = client.Read(dr["client_id"].ToString());

            VehicleDAO car = new VehicleDAO();
            rent.RenterVehicle = car.Read(dr["vehicle_id"].ToString());

            RentPlanDAO plan = new RentPlanDAO();
            rent.RentPlan = plan.Read(dr["plan_id"].ToString());

            PaymentDAO payment = new PaymentDAO();
            rent.PaymentMethod = payment.Read(dr["payment_method"].ToString());

            rent.RentDate = Convert.ToDateTime(dr["rent_date"]);
            rent.DevolutionDate = Convert.ToDateTime(dr["devolution_date"]);
            rent.InitialValue = Convert.ToDouble(dr["initial_value"]);
            rent.TotalValue = Convert.ToDouble(dr["total_value"]);
            switch (Convert.ToInt16(dr["status"]))
            {
                case 1:
                    rent.Status = Model.RentCar.RentStatus.Open;
                    break;
                case 2:
                    rent.Status = Model.RentCar.RentStatus.Running;
                    break;
                case 3:
                    rent.Status = Model.RentCar.RentStatus.Finished;
                    break;
                default:
                    break;
            }
            rent.IsPaid = Convert.ToBoolean(dr["is_paid"]);

            return rent;
        }

        public void Update(Model.RentCar renting)
        {
            Model.RentCar check = new Model.RentCar();
            check = Read(renting.Id);
            if (check == null)
            {
                InvalidOperationException error = new InvalidOperationException();
                throw error;
            }

            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("UPDATE rentida.rent_car SET vehicle_id = '{0}', plan_id = '{1}', payment_method = '{2}', rent_date = '{3}', devolution_date = '{4}', initial_value = '{5}', total_value = '{6}', status = '{7}', is_paid = '{8}'" + "WHERE id ='{9}'",
                renting.Renter.Id, renting.RenterVehicle.Id, renting.RentPlan.Id, renting.PaymentMethod.Id,
                renting.RentDate, renting.DevolutionDate, renting.InitialValue, renting.TotalValue,
                renting.Status, renting.IsPaid, renting.Id);

            rentida.ExecuteNonQuery(query);
        }

        public void Delete(int id)
        {
            try
            {
                Database.Database rentida = Database.Database.GetInstance();
                string query = string.Format("DELETE from rentida.rent_car WHERE id =" + id);

                rentida.ExecuteNonQuery(query);
            }
            catch (ArgumentException)
            {
                ArgumentException error = new ArgumentException();
                throw error;
            }
        }

        public List<Model.RentCar> ListAll()
        {
            List<Model.RentCar> rentingList = new List<Model.RentCar>();
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.rent_car";
            DataSet ds = rentida.ExecuteQuery(query);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Model.RentCar rent = new Model.RentCar();
                rent.Id = dr["id"].ToString();

                ClientDAO client = new ClientDAO();
                rent.Renter = client.Read(dr["client_id"].ToString());

                VehicleDAO car = new VehicleDAO();
                rent.RenterVehicle = car.Read(dr["vehicle_id"].ToString());

                RentPlanDAO plan = new RentPlanDAO();
                rent.RentPlan = plan.Read(dr["plan_id"].ToString());

                PaymentDAO payment = new PaymentDAO();
                rent.PaymentMethod = payment.Read(dr["payment_method"].ToString());

                rent.RentDate = Convert.ToDateTime(dr["rent_date"]);
                rent.DevolutionDate = Convert.ToDateTime(dr["devolution_date"]);
                rent.InitialValue = Convert.ToDouble(dr["initial_value"]);
                rent.TotalValue = Convert.ToDouble(dr["total_value"]);
                switch (Convert.ToInt16(dr["status"]))
                {
                    case 1:
                        rent.Status = Model.RentCar.RentStatus.Open;
                        break;
                    case 2:
                        rent.Status = Model.RentCar.RentStatus.Running;
                        break;
                    case 3:
                        rent.Status = Model.RentCar.RentStatus.Finished;
                        break;
                    default:
                        break;
                }
                rent.IsPaid = Convert.ToBoolean(dr["is_paid"]);
                rentingList.Add(rent);
            }

            return rentingList;
        }
    }
}
