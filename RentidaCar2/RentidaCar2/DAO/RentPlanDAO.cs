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
            string query = string.Format("INSERT INTO rentida.plan(plan_name, base_value, starter_km, additional_value, daily_value, car_type) VALUES('{0}','{1}','{2}','{3}','{4}')", 
                plan.PlanName, plan.BaseValue, plan.StarterKm, plan.AdditionalValue, plan.DailyValue, plan.CarType);

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
            plan.BaseValue = Convert.ToDouble(dr["base_value"].ToString());
            plan.StarterKm = Convert.ToInt16(dr["starter_km"].ToString());
            plan.AdditionalValue = Convert.ToDouble(dr["additional_value"].ToString());
            plan.DailyValue = Convert.ToDouble(dr["daily_value"].ToString());
            plan.CarType = Vehicle.Type.Complete;

            return plan;
        }

        public void Update(RentPlan plan)
        {

        }

        public void Delete(string id)
        {

        }
    }
}
