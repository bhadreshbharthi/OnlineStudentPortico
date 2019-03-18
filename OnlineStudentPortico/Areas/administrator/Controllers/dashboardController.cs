using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStudentPortico.Areas.administrator.Controllers
{
    public class dashboardController : Controller
    {
        // GET: administrator/dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}