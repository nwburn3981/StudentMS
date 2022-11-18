using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StuMS.Areas.Student.Controllers
{
    public class GradesController : Controller
    {
        // GET: GradesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GradesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GradesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GradesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GradesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GradesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GradesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GradesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
