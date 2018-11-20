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
            string query = string.Format("", plan.Id);

            rentida.ExecuteNonQuery(query);
        }

        public RentPlan Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno WHERE cpf=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            RentPlan plan = new RentPlan();

            DataRow dr = ds.Tables[0].Rows[0];
            plan.Id = dr["id"].ToString();

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
