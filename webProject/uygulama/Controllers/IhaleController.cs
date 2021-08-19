using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using uygulama.Entity;

namespace uygulama.Controllers
{
    public class IhaleController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Ihale
        public ActionResult Index()
        {
            return View(db.ıhaleBilgileris.ToList());
        }

        // GET: Ihale/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IhaleBilgileri ihaleBilgileri = db.ıhaleBilgileris.Find(id);
            if (ihaleBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(ihaleBilgileri);
        }

        // GET: Ihale/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ihale/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IhaleID,KategoriID,IhaleDurum,BaslangicFiyat,IhaleBaslangicT,IhaleBitisT,OnaylananTeklifID,IhaleDetayBilgi,IhaleUrunIsmi,Image")] IhaleBilgileri ihaleBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.ıhaleBilgileris.Add(ihaleBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ihaleBilgileri);
        }

        // GET: Ihale/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IhaleBilgileri ihaleBilgileri = db.ıhaleBilgileris.Find(id);
            if (ihaleBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(ihaleBilgileri);
        }

        // POST: Ihale/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IhaleID,KategoriID,IhaleDurum,BaslangicFiyat,IhaleBaslangicT,IhaleBitisT,OnaylananTeklifID,IhaleDetayBilgi,IhaleUrunIsmi,Image")] IhaleBilgileri ihaleBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ihaleBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ihaleBilgileri);
        }

        // GET: Ihale/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IhaleBilgileri ihaleBilgileri = db.ıhaleBilgileris.Find(id);
            if (ihaleBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(ihaleBilgileri);
        }

        // POST: Ihale/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IhaleBilgileri ihaleBilgileri = db.ıhaleBilgileris.Find(id);
            db.ıhaleBilgileris.Remove(ihaleBilgileri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
