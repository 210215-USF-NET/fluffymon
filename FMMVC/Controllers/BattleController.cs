using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMMVC.Controllers
{
    public class BattleController : Controller
    {
        // GET: BattleController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BattleWild()
        {
            return View();
        }
        public ActionResult BattleUser()
        {
            return View();
        }
        public ActionResult Fight()
        {
            /*
             *Wild Fluffymon = Attacker, User Fluffymon = Defender
             *
             DMGDef = Defender.Fluffiness - Attacker.AES
             Attacker.Fluffiness = Attacker.Fluffiness - DMGDef
             DMGAtk = Defender.Fluffiness - Defender.AES
             Defender.Fluffiness = Defender.Fluffiness - DMGAtk
             */
            return View("BattleWild");
        }
        // GET: BattleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BattleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BattleController/Create
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

        // GET: BattleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BattleController/Edit/5
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

        // GET: BattleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BattleController/Delete/5
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
