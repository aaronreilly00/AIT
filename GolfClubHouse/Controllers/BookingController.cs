using GolfClubHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GolfClubHouse.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        private ApplicationDbContext db;

        public BookingController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            
            return View(db.Bookings.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}