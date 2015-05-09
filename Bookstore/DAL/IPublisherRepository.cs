using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public interface IPublisherRepository
    {
        IEnumerable<Publisher> GetPublishers();
        Publisher GetPublisherByID(int id);
        void InsertPublisher(Publisher publisher);
        void DeletePublisher(int id);
        void UpdatePublisher(Publisher publisher);
        void Save();
    }
}
