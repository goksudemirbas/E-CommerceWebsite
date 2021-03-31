using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ETicaretMvc.Models.Sınıflar;
namespace ETicaretMvc.Controllers
{
    public class CariController : Controller
    {
        // GET: Cari
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Carilers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniEkle(Cariler p)
        {
            c.Carilers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}