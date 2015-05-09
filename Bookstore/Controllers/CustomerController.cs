using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookstore.DAL;
using Bookstore.Models;
using PagedList;

namespace Bookstore.Controllers
{
    public class CustomerController : Controller
    {
        private IRepository<Customer>  _repository;
        public CustomerController()
        {
            this._repository = new CustomerRepository(new CustomerContext());
        }
        public ActionResult Index(String Search_Data, int? Page_No)
        {
            List<Customer> result= null;
            if (String.IsNullOrEmpty(Search_Data))
            {
                result = _repository.List.ToList();
            }
            else
            {
                Page_No = 1;
                result = _repository.List.ToList().Where(x => x.FirstName.ToUpper() == Search_Data.ToUpper()).ToList();
            }
            int Size_Of_Page = 2;
            int No_Of_Page = (Page_No ?? 1);
            return View(result.ToPagedList(No_Of_Page, Size_Of_Page));

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Customer());
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(customer);
                return RedirectToAction("Index");
            }
            else
                return View(customer);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Customer authortoEdit = _repository.FindByID(id);
            return View(authortoEdit);
        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            _repository.Update(customer);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Customer customer = _repository.FindByID(id);
            return View(customer);
        }
        public ActionResult Delete(int id)
        {
            Customer customer = _repository.FindByID(id);
            _repository.Delete(customer);
            return RedirectToAction("Index");
        }


    }
}