using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDao
    {
        EntityDesignForProductsEntities DBService = new EntityDesignForProductsEntities();

        public void SaveToDatabase(Customer obj)
        {

            DBService.Customers.Add(obj);
            DBService.SaveChanges();
        }


        public void UpdateRecordInDatabase(Customer obj)
        {

            DBService.Customers.Add(obj);
            DBService.SaveChanges();
        }


        public Customer GetDetailFromDatabase(int id)
        {

            return DBService.Customers.Find(id);
        }


        public void DeleteFromDatabase(int id)
        {
            Customer obj = new Customer(); 
            obj = DBService.Customers.Find(id);
            DBService.Customers.Remove(obj);
        }
        public List<Customer> GetListOfCustomersFromDatabase()
        {
            List<Customer> lst = new List<Customer>();
 
            lst = DBService.Customers.ToList();
            return lst; 
        }

        //Use Lambda Expression to get Customer whose name is like
        public List<Customer> GetListOfCustomersFromDatabase(string nameFilter)
        {
            List<Customer> lst = new List<Customer>();

            lst = DBService.Customers.Where(x => x.CustFname.Contains(nameFilter)).ToList(); 
            return lst;
        }







    }
}
