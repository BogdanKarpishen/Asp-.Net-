using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;
using BlogDatabase;

namespace Task1.Controllers
{
    /*TODO список отзывов
     добавить для классов работающих с базой IDisposable*/
    public class HomeController : Controller
    {
        static List<Review> reviews = new List<Review>();
        public ActionResult Index()
        {
                BlogDBContext blogDbContext = new BlogDBContext();

                List<Article> articles = new List<Article>();
                blogDbContext.Articles.Select(m => m.Id);
            /* foreach (var item in blogDB.Articles)
             {

             }*/
            ViewBag.Message = blogDbContext.Articles.Count();
            return View();
        }

        public ActionResult Guest(string userName,string creationDate,string review)
        {
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            reviews.Add(new Review(userName, creationDate, review));
            return View((object)reviews);
        }
        public ActionResult Form(FormCollection form)
        {
            ViewBag.secretNames = new string[]
            { "Шелест ветра", "Журчащий ручей", "Резкий богомол", "Спящая панда" };
            ViewBag.pictures = new string[] { "_1", "_2", "_3" };

            if (Request.HttpMethod == "POST")
            {
                Task1.Models.Form result =
                     new Form(string.Join("", form.GetValues(0)),
                     string.Join("", form.GetValues(1)),
                     string.Join("", form.GetValues(2)),
                     form.GetValues(3),
                     form.GetValues(4));
                
                return View(result);
            }

            else
                
                return View();
        }


    }

}