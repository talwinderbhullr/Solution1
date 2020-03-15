using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SaleDao
    {
        EntityDesignForProductsEntities DBService = new EntityDesignForProductsEntities();

        public void SaveToDatabase(sale obj)
        {

            DBService.sales.Add(obj);
            DBService.SaveChanges();
        }


        public void UpdateRecordInDatabase(sale obj)
        {

            DBService.sales.Add(obj);
            DBService.SaveChanges();
        }


        public sale GetDetailFromDatabase(int id)
        {

            return DBService.sales.Find(id);
        }


        public void DeleteFromDatabase(int id)
        {
            sale obj = new sale();
            obj = DBService.sales.Find(id);
            DBService.sales.Remove(obj);
        }
        public List<sale> GetListOfsalesFromDatabase()
        {
            List<sale> lst = new List<sale>();

            lst = DBService.sales.ToList();
            return lst;
        }
 



    }
}
