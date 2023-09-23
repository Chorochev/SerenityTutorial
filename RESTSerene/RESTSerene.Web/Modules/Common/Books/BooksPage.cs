using Microsoft.AspNetCore.Mvc;
using RESTSerene.Web.RESTServices;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Web;
using System.Collections.Generic;

namespace RESTSerene.Common.Pages
{
    public class BooksController : Controller
    {
        [Route("~/Books")]
        public ActionResult Index([FromServices] IRESTTableClient restClient)
        {
            var model = new BooksPageModel();
            model.Books = new List<BookPageModel>();
            foreach (var item in restClient.List("books"))
            {
                model.Books.Add((BookPageModel)item);
            }
            return View(MVC.Views.Common.Books.BooksIndex, model);
        }
    };
}
