using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;
using BlogDatabase;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            DbOperations<Articles> operations = new DbOperations<Articles>();


            return View(operations.SelectAll());
        }

        public ActionResult Guest(string userName,Nullable<DateTime> creationDate,string review)
        {
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            {
            DbOperations<Comments> operations = new DbOperations<Comments>();
            operations.Add(new Comments(userName,creationDate.Value,review));
            
            return View(operations.SelectAll());
            }
            
        }
        public ActionResult Form(FormCollection form)
        {
            ViewBag.secretNames = new string[]
            { "Шелест ветра", "Журчащий ручей", "Резкий богомол", "Спящая панда" };
            ViewBag.pictures = new string[] { "_1", "_2", "_3" };

            if (Request.HttpMethod == "POST")
            {
                DbOperations<Forms> operations = new DbOperations<Forms>();
                operations.Edit(new Forms(string.Join("", form.GetValues(0)),
                     string.Join("", form.GetValues(1)),
                     string.Join("", form.GetValues(2)),
                     form.GetValues(3),
                     form.GetValues(4)));

                return View(operations.SelectAll().First());
            }

            else
                
                return View();
        }
        [HttpPost]
        public ActionResult CreateNewArticle(Articles articles)
        {
            DbOperations<Articles> operations = new DbOperations<Articles>();

            operations.Add(articles);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateNewArticle()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditArticle(int id)
        {
            DbOperations<Articles> operations = new DbOperations<Articles>();
            return View(operations.SelectAll().Find(m =>m.Id == id));
        }
        [HttpPost]
        public ActionResult EditArticle(Articles articles)
        {

            return RedirectToAction("Index");
        }
        public ActionResult DeleteArticle(int id)
        {
            DbOperations<Articles> operations = new DbOperations<Articles>();
            operations.Delete(id);
            return RedirectToAction("Index");
        }
    }

}