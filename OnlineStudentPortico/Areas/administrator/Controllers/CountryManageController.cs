using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnlineStudentPortico.Models;

namespace OnlineStudentPortico.Areas.administrator.Controllers
{
    public class CountryManageController : Controller
    {
        dbLocationEntities db = new dbLocationEntities();

        // GET: administrator/CountryManage
        public ActionResult Index()
        {
            return View(db.CountryMasters.ToList());
        }

       

    }
}