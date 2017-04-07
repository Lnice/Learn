using System.Web.Mvc;

namespace Lnice.Web.Controllers
{
    public class HomeController : LniceControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}