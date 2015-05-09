using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookstore.Models;
using Bookstore.DAL;
namespace Bookstore.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthorRepository _authorRepository;
        public  AuthorController()
        {
            this._authorRepository = new AuthorRepository(new AuthorContext());
        }
        // GET: Author
        public ActionResult Index()
        {
            List<Author> authors = _authorRepository.GetAuthors().ToList();
            return View(authors);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View( new Author());
        }
        [HttpPost]
        public ActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                _authorRepository.InsertAuthor(author);
                _authorRepository.Save();
                return RedirectToAction("Index");
            }
            else
                return View(author);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Author authortoEdit = _authorRepository.GetAuthorByID(id);
            return View(authortoEdit);
        }
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            _authorRepository.UpdateAuthor(author);
            _authorRepository.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Author author = _authorRepository.GetAuthorByID(id);
            return View(author);
        }
        public ActionResult Delete(int id)
        {
            _authorRepository.DeleteAuthor(id);
            _authorRepository.Save();
            return RedirectToAction("Index");
        }
    }
}