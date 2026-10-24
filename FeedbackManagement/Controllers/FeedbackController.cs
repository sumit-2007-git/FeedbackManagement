
using System.Collections.Generic;
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        private static readonly List<Feedback> feedbackList =
            new List<Feedback>();

        public ActionResult Index()
        {
            return View(feedbackList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                TempData["Message"] = "Feedback submitted successfully!";
                return RedirectToAction("Index");
            }

            return View(feedbackList);
        }
    }
}
