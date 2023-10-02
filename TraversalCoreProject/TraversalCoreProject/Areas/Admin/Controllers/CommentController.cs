using BusinessLayer.Abstarct;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentservice;

        public CommentController(ICommentService commentservice)
        {
            _commentservice = commentservice;
        }

        public IActionResult Index()
        {
            var values = _commentservice.TGetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = _commentservice.TGetByID(id);
            _commentservice.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
