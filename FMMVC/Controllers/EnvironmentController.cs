using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using env=FMMVC.Models.Environment;
namespace FMMVC.Controllers
{
    public class EnvironmentController : Controller
    {
        // GET: EnvironmentController1
        public ActionResult Index()
        {
            return RedirectToAction(env.GetLocation());
        }
        public ActionResult BendyRoad()
        {
            return View();
        }

        public ActionResult Graveyard()
        {
            return View();
        }

        public ActionResult Hills()
        {
            return View();
        }

        public ActionResult Wall()
        {
            return View();
        }

        public ActionResult Kitchen() {
            return View();
        }

        public ActionResult Road()
        {
            return View();
        }


        public ActionResult School()
        {
            return View();
        }

        public ActionResult Library()
        {
            return View();
        }


        public ActionResult North()
        {
            env.north();
            
            return RedirectToAction(env.GetLocation());

        }

        public ActionResult South()
        {
            env.south();

            return RedirectToAction(env.GetLocation());

        }


        public ActionResult West()
        {
            env.west();

            return RedirectToAction(env.GetLocation());
        }


        public ActionResult East()
        {
            env.east();


            return RedirectToAction(env.GetLocation());

        }








        // GET: EnvironmentController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnvironmentController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnvironmentController1/Create
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

        // GET: EnvironmentController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnvironmentController1/Edit/5
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

        // GET: EnvironmentController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnvironmentController1/Delete/5
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
