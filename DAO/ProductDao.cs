using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProductDao
    {
        EntityDesignForProductsEntities DBService = new EntityDesignForProductsEntities();

        public void SaveToDatabase(Product obj)
        {

            DBService.Products.Add(obj);
            DBService.SaveChanges();
        }


        public void UpdateRecordInDatabase(Product obj)
        {

            DBService.Products.Add(obj);
            DBService.SaveChanges();
        }


        public Product GetDetailFromDatabase(int id)
        {

            return DBService.Products.Find(id);
        }


        public void DeleteFromDatabase(int id)
        {
            Product obj = new Product();
            obj = DBService.Products.Find(id);
            DBService.Products.Remove(obj);
        }
        public List<Product> GetListOfProductsFromDatabase()
        {
            List<Product> lst = new List<Product>();

            lst = DBService.Products.ToList();
            return lst;
        }

        //Use Lambda Expression to get Product whose name is like
        public List<Product> GetListOfProductsFromDatabase(string nameFilter)
        {
            List<Product> lst = new List<Product>();

            lst = DBService.Products.Where(x => x.ProductName.Contains(nameFilter)).ToList();
            return lst;
        }







    }
}
