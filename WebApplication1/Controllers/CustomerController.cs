using BAO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDao dao = new CustomerDao();

        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> listprodcuts = new List<Customer>();
            listprodcuts = dao.GetListOfCustomersFromDatabase();
            return View(listprodcuts);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int? id)
        {
            Customer customer = new Customer();
            customer = dao.GetDetailFromDatabase(Convert.ToInt32(id));
            return View(customer);
        }


        // GET: Customer/Create
        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
               
                dao.SaveToDatabase(customer);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
            }
            return RedirectToAction("Index");

        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int? id)
        {

            Customer customer = new Customer();
            customer = dao.GetDetailFromDatabase(Convert.ToInt32(id)); 
            return View(customer);

             
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            try
            {

                dao.SaveToDatabase(customer);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
            }
            return RedirectToAction("Index");

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
