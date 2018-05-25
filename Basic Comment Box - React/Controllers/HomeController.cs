using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Basic_Comment_Box___React.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ICollection<Models.Comment> _comments;

        static HomeController()
        {
            _comments = new HashSet<Models.Comment>
            {
                new Models.Comment
                {
                    Id = 1,
                    Author = "Princess Leia",
                    Text = "Help me, Obi-Wan Kenobi. You're my only hope."
                },
                 new Models.Comment
                {
                    Id = 2,
                    Author = "Luke Skywalker",
                    Text = "I am a Jedi, like my father before me."
                },
                  new Models.Comment
                {
                    Id = 3,
                    Author = "Han Solo",
                    Text = "Never tell me the odds!"
                }
            };
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult Comments()
        {
            return Json(_comments, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View(_comments);
        }

        [HttpPost]
        public ActionResult AddComment(Models.Comment comment)
        {
            // Create a fake Id for new comment
            comment.Id = _comments.Count + 1;
            _comments.Add(comment);
            return Content("Success!");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}