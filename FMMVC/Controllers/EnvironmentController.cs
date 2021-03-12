using FMBL;
using FMModels;
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
        private IFluffyBL fluffyBL;
        public EnvironmentController(IFluffyBL fluffyBL)
        {
            this.fluffyBL = fluffyBL;
        }
        // GET: EnvironmentController1
        public ActionResult Index()
        {
            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return RedirectToAction(env.GetLocation());
        }
        public ActionResult BendyRoad()
        {
            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return new Random().Next(10) == 0 ? Encounter() : View();

        }

        public ActionResult Graveyard()
        {

            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return new Random().Next(10) == 0 ? Encounter() : View();

        }

        public ActionResult Hills()
        {
            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return new Random().Next(10) == 0 ? Encounter() : View();

        }

        public ActionResult Wall()
        {
            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return View();
        }

        public ActionResult Kitchen() {

            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return new Random().Next(10) == 0 ? Encounter() : View();

            return View();

        }

        public ActionResult Road()
        {
            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return new Random().Next(10) == 0 ? Encounter() : View();

 
          //  return View();

        }


        public ActionResult School()
        {
            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return new Random().Next(10) == 0 ? Encounter() : View();

     
           // return View();

        }

        public ActionResult Library()
        {
            ViewData["North"] = env.Getnorth();
            ViewData["South"] = env.Getsouth();
            ViewData["East"] = env.Geteast();
            ViewData["West"] = env.Getwest();
            return new Random().Next(10) == 0 ? Encounter() : View();



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

        public ActionResult Encounter()
        {
            List<Fluffymon> fluffymon = fluffyBL.GetFluffymons();
            if (fluffymon.Count == 0) throw new Exception("No fluffymon in db");
            int index = new Random().Next(0, fluffymon.Count);
            return View(fluffymon[index]);
        }

        [HttpPost]
        public ActionResult Encounter(Fluffymon fmon)
        {
            UserFluffymon ufm = new UserFluffymon();
            ufm.UserId = (int)HttpContext.Session.GetInt32("UserId");
            ufm.FluffymonId = fmon.FluffymonId;
            fluffyBL.AddUserFluffymon(ufm);
            return Redirect("/");
        }
    }
}
