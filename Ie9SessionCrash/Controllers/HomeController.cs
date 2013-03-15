using System.Web.Mvc;
using System.Web.SessionState;

namespace Ie9SessionCrash.Controllers
{
    [SessionState(SessionStateBehavior.Required)]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Session["something"] = "value";
            return View();
        }
    }
}
