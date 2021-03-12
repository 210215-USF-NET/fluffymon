using FMBL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMMVC.Controllers
{
    public class CapturedController : Controller
    {
        private IFluffyBL _fluffyBL;
        public CapturedController(IFluffyBL fluffyBL)
        {
            _fluffyBL = fluffyBL;
        }

        // GET: CapturedController
        public ActionResult Index()
        {
            return View(_fluffyBL.GetUserFluffymons());
        }

        // GET: CapturedController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CapturedController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapturedController/Create
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

        // GET: CapturedController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CapturedController/Edit/5
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

        // GET: CapturedController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CapturedController/Delete/5
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
