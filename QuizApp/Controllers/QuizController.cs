using QuizApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizApp.EF.Models;

namespace QuizApp.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddQuiz()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddQuiz(Question question)
        {
            
            QuizDB db = new QuizDB();
            db.Questions.Add(question);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult TakeQuiz()
        {
            QuizDB db = new QuizDB();
            var list = db.Questions.ToList();
            return View(list);
        }

        [HttpPost]
        public ActionResult TakeQuiz(Answer model)
        {
            QuizDB db = new QuizDB();
            db.Answers.Add(model);
            db.SaveChanges();
            return View();
        }
    }
}