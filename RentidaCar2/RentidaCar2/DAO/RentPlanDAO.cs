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
    class RentPlanDAO
    {
        public void Create(RentPlan plan)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("INSERT INTO rentida.plan(plan_name, base_value, starter_km, additional_value, daily_value, car_type) VALUES('{0}','{1}','{2}','{3}','{4}', '{5}')", 
                plan.PlanName, plan.BaseValue, plan.StarterKm, plan.AdditionalValue, plan.DailyValue, (int) plan.CarType);

            rentida.ExecuteNonQuery(query);
        }

        public RentPlan Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.plan WHERE id=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            RentPlan plan = new RentPlan();

            DataRow dr = ds.Tables[0].Rows[0];
            plan.Id = dr["id"].ToString();
            plan.PlanName = dr["plan_name"].ToString();
            plan.BaseValue = Convert.ToDouble(dr["base_value"]);
            plan.StarterKm = Convert.ToInt16(dr["starter_km"]);
            plan.AdditionalValue = Convert.ToDouble(dr["additional_value"]);
            plan.DailyValue = Convert.ToDouble(dr["daily_value"]);
            switch (Convert.ToInt16(dr["car_type"]))
            {
                case 1:
                    plan.CarType = Vehicle.Type.Simple;
                    break;
                case 2:
                    plan.CarType = Vehicle.Type.Complete;
                    break;
                case 3:
                    plan.CarType = Vehicle.Type.Premmium;
                    break;
                default:
                    break;
            }

            return plan;
        }

        public void Update(RentPlan plan)
        {
            RentPlan check = new RentPlan();
            check = Read(plan.Id);
            if (check == null)
            {
                InvalidOperationException error = new InvalidOperationException();
                throw error;
            }
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("UPDATE rentida.plan SET plan_name='{0}', base_value='{1}', starter_km='{2}', additional_value='{3}', daily_value='{4}', car_type='{5}'" + "WHERE id ='{6}'",
                plan.PlanName, plan.BaseValue, plan.StarterKm, plan.AdditionalValue, plan.DailyValue, plan.CarType, plan.Id);

            rentida.ExecuteNonQuery(query);
        }

        public void Delete(string id)
        {
            try
            {
                Database.Database rentida = Database.Database.GetInstance();
                string query = string.Format("DELETE from rentida.plan WHERE id =" + id);

                rentida.ExecuteNonQuery(query);
            }
            catch (ArgumentException)
            {
                ArgumentException error = new ArgumentException();
                throw error;
            }
        }

        public List<RentPlan> ListAll()
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM rentida.plan";
            DataSet ds = rentida.ExecuteQuery(query);
            List<RentPlan> planList = new List<RentPlan>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                RentPlan plan = new RentPlan();
                plan.Id = dr["id"].ToString();
                plan.PlanName = dr["plan_name"].ToString();
                plan.BaseValue = Convert.ToDouble(dr["base_value"]);
                plan.StarterKm = Convert.ToInt16(dr["starter_km"]);
                plan.AdditionalValue = Convert.ToDouble(dr["additional_value"]);
                plan.DailyValue = Convert.ToDouble(dr["daily_value"]);
                switch (Convert.ToInt16(dr["car_type"]))
                {
                    case 1:
                        plan.CarType = Vehicle.Type.Simple;
                        break;
                    case 2:
                        plan.CarType = Vehicle.Type.Complete;
                        break;
                    case 3:
                        plan.CarType = Vehicle.Type.Premmium;
                        break;
                    default:
                        break;
                }

                planList.Add(plan);
            }
            return planList;
        }
    }
}
