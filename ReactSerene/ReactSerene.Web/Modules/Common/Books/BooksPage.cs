using Microsoft.AspNetCore.Mvc;

namespace ReactSerene.Common.Pages
{
    public class BooksController : Controller
    {       
        [Route("~/Books")]
        public ActionResult Index()
        {
            return View(MVC.Views.Common.Books.BooksIndex);
        }
    }
}
