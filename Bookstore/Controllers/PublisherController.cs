using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookstore.DAL;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class PublisherController : Controller
    {
        private IPublisherRepository _publisherRepository;
        // GET: Publisher
        public PublisherController()
        {
            this._publisherRepository= new PublisherRepository(new PublisherContext());
        }
        public ActionResult Index()
        {
            List<Publisher> publishers = _publisherRepository.GetPublishers().ToList();
            return View(publishers);
        }
        [HttpPost]
        public ActionResult Create(Publisher publisher)
        {
            _publisherRepository.InsertPublisher(publisher);
            _publisherRepository.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Publisher());
        }
        public ActionResult Edit(int id)
        {
            return View(_publisherRepository.GetPublisherByID(id));
        }
        [HttpPost]
        public ActionResult Edit(Publisher publisher)
        {
            _publisherRepository.UpdatePublisher(publisher);
            _publisherRepository.Save();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            return View(_publisherRepository.GetPublisherByID(id));
        }
        public ActionResult Delete(int id)
        {
            _publisherRepository.DeletePublisher(id);
            _publisherRepository.Save();
            return RedirectToAction("Index");
        }
    }
}