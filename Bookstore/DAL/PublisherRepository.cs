using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.Models;
using System.Data.Entity;

namespace Bookstore.DAL
{
    public class PublisherRepository:IPublisherRepository ,IDisposable 
    {
        private PublisherContext _publisherContext;

        public PublisherRepository(PublisherContext dbContext)
        {
            this._publisherContext = dbContext;
        }
        public IEnumerable<Publisher> GetPublishers() 
        {  
            return _publisherContext.Publishers.ToList();
        }
        public void InsertPublisher(Publisher publisher)
        {
            _publisherContext.Publishers.Add(publisher);

        }
        public Publisher GetPublisherByID(int id )
        {
           return _publisherContext.Publishers.SingleOrDefault(x => x.id == id);
        }
        public void UpdatePublisher(Publisher publisher)
        {
            Publisher publisherToUpdate = _publisherContext.Publishers.SingleOrDefault(x => x.id == publisher.id);
            publisherToUpdate.Name = publisher.Name;
            _publisherContext.Entry(publisherToUpdate).State = EntityState.Modified;
        }
        public void DeletePublisher(int Id)
        {
            Publisher publisherToDelete = _publisherContext.Publishers.SingleOrDefault(x => x.id == Id);
            _publisherContext.Publishers.Remove(publisherToDelete);

        }
        public void Save()
        {
            _publisherContext.SaveChanges();
        }
        private bool disposed = false;
        protected void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing )
                {
                    _publisherContext.Dispose();
                }
                disposed=true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}