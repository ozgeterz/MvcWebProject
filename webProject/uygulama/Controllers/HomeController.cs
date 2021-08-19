using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uygulama.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uygulama.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.ıhaleBilgileris.Where(i => i.IhaleDurum == "Aktif").ToList());
        }
     
        public ActionResult arazitarla()
        {
            return View(_context.ıhaleBilgileris.Where(i => i.IhaleDurum == "Aktif").Where(i => i.KategoriID == 40).ToList());
        }

        public ActionResult fabrika()
        {
            return View(_context.ıhaleBilgileris.Where(i => i.IhaleDurum=="Aktif").Where(i=>i.KategoriID==50).ToList());
        }

        public ActionResult evaleti( )
        {
            return View(_context.ıhaleBilgileris.Where(i => i.IhaleDurum=="AKtif" && i.KategoriID== 20).ToList());
        }

        public ActionResult aracotomobil()
        {
            return View(_context.ıhaleBilgileris.Where(i => i.IhaleDurum == "Aktif").Where(i => i.KategoriID == 30).ToList());
        }
        public ActionResult teknoloji()
        {
            return View(_context.ıhaleBilgileris.Where(i => i.IhaleDurum == "Aktif").Where(i => i.KategoriID == 10).ToList());
        }
        public ActionResult iletisim()
        {
            return View();
        }
        public ActionResult teklif()
        {
            return View();
        }

        public ActionResult giris()
        {
            return View();
        }
        public ActionResult urundetay(int id)
        {
            return View(_context.ıhaleBilgileris.Where(i=>i.IhaleID==id).FirstOrDefault());
        }

    }

}