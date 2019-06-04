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
        static Voting voting = new Voting(0, "Best Ninja Film", new List<VoteOption>() {
                new VoteOption(0,"Teanage Mutants Ninja Tortoises (2016)"),
                new VoteOption(0,"American Ninja (1985)"),
                new VoteOption(0,"Ninja Killer (2009)")});

        public ActionResult Index()
        {
            ViewBag.Vote = voting;
            DbOperations<Articles> operations = new DbOperations<Articles>();
            
            return View(operations.SelectAll());

        }
        public ActionResult Vote(int vote =-1)
        {
            if(vote!=-1)
            voting.Options[vote].Vote++;
            return RedirectToAction("Index");
        }

        public ActionResult FullArticleView(int id = 1)
        {
            ViewBag.Id = id;
            DbOperations<Articles> operations = new DbOperations<Articles>();
            Articles article = operations.SelectAll().Find(m => m.Id == id);
            ArticleViewModel viewModel = new ArticleViewModel(article.Name,article.Date, article.Creator, article.Text, article.Tags);
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Guest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guest(CommentsViewModel comments)
        {
            DbOperations<Comments> operations = new DbOperations<Comments>();
            operations.Add(new Comments(comments.userName,DateTime.UtcNow,comments.review));
            
            return View(operations.SelectAll());
            
        }
        /*TODO 
         * 1 Поменять форму
         * 2 Поменять верстку
         * 3 Задание
         */
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
        public ActionResult CreateNewArticle(Articles articles, List<Tag> Tags)
        {
            DbOperations<Articles> operations = new DbOperations<Articles>();
            operations.Add(new Articles(articles.Name,articles.Creator,articles.Date.Date,articles.Text,Tags));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateNewArticle()
        {
            Articles article = new Articles("","",DateTime.UtcNow,"",new List<Tag>());
            return View(article);
        }

        [HttpGet]
        public ActionResult EditArticle(int? id)
        {
            if(id == null) return RedirectToAction("Index");
            DbOperations<Articles> operations = new DbOperations<Articles>();
            return View(operations.SelectAll().Find(m =>m.Id == id));
        }

        [HttpPost]
        public ActionResult EditArticle(Articles articles, List<Tag> Tags)
        {
            DbOperations<Articles> operations = new DbOperations<Articles>();
            operations.Edit(articles);
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