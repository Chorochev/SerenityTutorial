using Microsoft.AspNetCore.Mvc;
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
        public ActionResult Index([FromServices] ITwoLevelCache cache, [FromServices] ISqlConnections sqlConnections)
        {
            var model = new BooksPageModel()
            {
                Books = new List<BookPageModel>()
                {
                    new BookPageModel() { Id = 1, Title = "Остров сокровищ", Info = "Приключения про поиск пиратских сокровищ." },
                    new BookPageModel() { Id = 2, Title = "Мастер и Маргарита", Info = "Про любовь." },
                    new BookPageModel() { Id = 3, Title = "Война и Мир", Info = "Про войну." }
                }
            };
            return View(MVC.Views.Common.Books.BooksIndex, model);
        }
    };
}
  