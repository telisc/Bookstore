using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bookstore.Models;
using Bookstore.DAL;

namespace Bookstore.Controllers
{
    public class BookWebApiController : ApiController
    {
        public IEnumerable<Book> Get()
        {
            IBookRepository _bookRepository = new BookRepository(new BookContext());
            return _bookRepository.GetBooks();
        }
    }
}
