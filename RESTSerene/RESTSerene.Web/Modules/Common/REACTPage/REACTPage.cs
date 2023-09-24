using Microsoft.AspNetCore.Mvc;
using RESTSerene.Common;
using RESTSerene.Web.RESTServices;
using System.Collections.Generic;

namespace RESTSerene.Common.Pages
{
    public class REACTPageController : Controller
    {
        [Route("~/REACTPage")]
        public ActionResult Index()
        {           
            return View(MVC.Views.Common.REACTPage.REACTIndex);
        }
    };
}
