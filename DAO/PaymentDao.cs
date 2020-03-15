using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PaymentDao
    {
        EntityDesignForProductsEntities DBService = new EntityDesignForProductsEntities();

        public void SaveToDatabase(Payment obj)
        {

            DBService.Payments.Add(obj);
            DBService.SaveChanges();
        }


        public void UpdateRecordInDatabase(Payment obj)
        {

            DBService.Payments.Add(obj);
            DBService.SaveChanges();
        }


        public Payment GetDetailFromDatabase(int id)
        {

            return DBService.Payments.Find(id);
        }


        public void DeleteFromDatabase(int id)
        {
            Payment obj = new Payment();
            obj = DBService.Payments.Find(id);
            DBService.Payments.Remove(obj);
        }
        public List<Payment> GetListOfPaymentsFromDatabase()
        {
            List<Payment> lst = new List<Payment>();

            lst = DBService.Payments.ToList();
            return lst;
        }

        //Use Lambda Expression to get Payment whose name is like
        public List<Payment> GetListOfPaymentsFromDatabase(string nameFilter)
        {
            List<Payment> lst = new List<Payment>();

            lst = DBService.Payments.Where(x => x.Amount>0).ToList();
            return lst;
        }










    }
}
