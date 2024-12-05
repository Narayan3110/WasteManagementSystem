using System.Linq;
using System.Web.Mvc;
using WasteManagementSystem.Data;
using WasteManagementSystem.Models;

namespace WasteManagementSystem.Controllers
{
    public class WasteRequestController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: WasteRequest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WasteRequest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WasteRequest wasteRequest)
        {
            if (ModelState.IsValid)
            {
                db.WasteRequests.Add(wasteRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wasteRequest);
        }

        // GET: WasteRequest/Index
        public ActionResult Index()
        {
            var wasteRequests = db.WasteRequests.ToList();
            return View(wasteRequests);
        }

        // GET: WasteRequest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            WasteRequest wasteRequest = db.WasteRequests.Find(id);
            if (wasteRequest == null)
            {
                return HttpNotFound();
            }
            return View(wasteRequest);
        }

        // GET: WasteRequest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            WasteRequest wasteRequest = db.WasteRequests.Find(id);
            if (wasteRequest == null)
            {
                return HttpNotFound();
            }
            return View(wasteRequest);
        }

        // POST: WasteRequest/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WasteRequest wasteRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wasteRequest).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wasteRequest);
        }

        // GET: WasteRequest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            WasteRequest wasteRequest = db.WasteRequests.Find(id);
            if (wasteRequest == null)
            {
                return HttpNotFound();
            }
            return View(wasteRequest);
        }

        // POST: WasteRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WasteRequest wasteRequest = db.WasteRequests.Find(id);
            db.WasteRequests.Remove(wasteRequest);
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
