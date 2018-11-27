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
    class PaymentDAO
    {
        public void Create(Payment payment)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("", payment.Id);

            rentida.ExecuteNonQuery(query);
        }

        public Payment Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM aluno WHERE cpf=" + id;
            DataSet ds = rentida.ExecuteQuery(query);
            Payment payment = new Payment();

            DataRow dr = ds.Tables[0].Rows[0];
            payment.Id = dr["id"].ToString();

            return payment;
        }

        public void Update(Payment address)
        {

        }

        public void Delete(string id)
        {

        }
    }
}
