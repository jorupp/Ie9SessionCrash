using System;
using System.Threading;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Ie9SessionCrash.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class ReadOnlySessionController : Controller
    {
        public ActionResult Sleep1()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            return Content("Sleep1");
        }

        public ActionResult Sleep5()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            return Content("Sleep5");
        }

        public ActionResult Sleep10()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            return Content("Sleep10");
        }
    }
}
