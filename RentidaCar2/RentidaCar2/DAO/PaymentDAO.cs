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
            Payment check = new Payment();
            check = Read(payment.Id);
            if (check != null)
            {
                InvalidOperationException error = new InvalidOperationException();
                throw error;
            }
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("INSERT INTO rentida.payment_method(method_name) VALUES('{0}')",
                 payment.MethodName);

            rentida.ExecuteNonQuery(query);
        }

        public Payment Read(string id)
        {
            Database.Database rentida = Database.Database.GetInstance();
            string query = "SELECT * FROM  rentida.payment_method WHERE id=" + Convert.ToInt16(id);
            DataSet ds = rentida.ExecuteQuery(query);
            Payment payment = new Payment();

            DataRow dr = ds.Tables[0].Rows[0];
            payment.Id = dr["id"].ToString();
            payment.MethodName = dr["method_name"].ToString();

            return payment;
        }

        public void Update(Payment payment)
        {
            Payment check = new Payment();
            check = Read(payment.Id);
            if (check == null)
            {
                InvalidOperationException error = new InvalidOperationException();
                throw error;
            }
            Database.Database rentida = Database.Database.GetInstance();
            string query = string.Format("UPDATE rentida.payment_method SET method_name='{0}'"+"WHERE id='{1}'",
                 payment.MethodName, Convert.ToInt16(payment.Id));

            rentida.ExecuteNonQuery(query);
        }

        public void Delete(string id)
        {
            try
            {
                Database.Database rentida = Database.Database.GetInstance();
                string query = string.Format("DELETE from rentida.payment_method WHERE id =" + Convert.ToInt16(id));

                rentida.ExecuteNonQuery(query);
            }
            catch (System.ArgumentException)
            {
                System.ArgumentException error = new ArgumentException();
                throw error;
            }
        }
    }
}
