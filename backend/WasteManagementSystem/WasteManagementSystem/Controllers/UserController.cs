using System.Linq;
using System.Web.Mvc;
using WasteManagementSystem.Data;
using WasteManagementSystem.Models;

namespace WasteManagementSystem.Controllers
{
    public class UserController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: User
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
