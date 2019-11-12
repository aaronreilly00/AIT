using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GolfClubHouse.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReleaseMonth(int year, int month)
        {
            return Content("Release Date : " + month + "/" + year);
        }

       
    }
}