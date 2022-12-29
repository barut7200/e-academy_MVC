using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [Route ("Hakkinda")]
        public ActionResult Hakkinda()
        {
            using(eacademiEntities db = new eacademiEntities())
            {
                var model = db.hakkinda.Find(1);
                return View (model);
            }
           
        }
        [Route("Dersler")]
        public ActionResult Dersler()
        {
            using (eacademiEntities db = new eacademiEntities())
            {
                var model = db.dersler.ToList();
                return View(model);
            }
        }
        [Route("Blog")]
        public ActionResult Blog()
        {
            return View();
        }
        [Route("Iletisim")]
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}