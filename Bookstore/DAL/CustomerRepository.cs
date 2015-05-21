using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.Models;
namespace Bookstore.DAL
{
    public class CustomerRepository:IRepository<Customer>
    {
         private CustomerContext  _context;

         public CustomerRepository(CustomerContext customerContext)
        {
            this._context = customerContext;
        }

         public IEnumerable<Customer> List
         {
             get
             {
                 return _context.Customers;
             }

         }

         public void Add(Customer entity)
         {
             _context.Customers.Add(entity);
             _context.SaveChanges();
         }

         public void Delete(Customer entity)
         {
             _context.Customers.Remove(entity);
             _context.SaveChanges();
         }

         public void Update(Customer entity)
         {
             _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
             _context.SaveChanges();

         }

         public Customer FindByID(String Id)
         {
             var result = (from r in _context.Customers where r.CustomerID == Id select r).FirstOrDefault();
             return result;
         }
         public Customer FindByID(int Id)
         {
             var result = (from r in _context.Customers where r.CustomerID == "CACTU" select r).FirstOrDefault();
             return result;
         }

    }
}