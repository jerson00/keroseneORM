using Kerosene.ORM.Core;
using KeroseneORMPresetation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeroseneORMPresetation.Controllers
{
    public class EquiposController : Controller
    {
        private IDataLink kConnection;
        public EquiposController()
        {
            KeroseneConection kc = new KeroseneConection();
            kConnection = kc.Conection();
        }

        // GET: Equipos

        public ActionResult Index()
        {
            ViewBag.equipos = Equipo.getEquipos(kConnection);
            return View();
        }

        // GET: Equipos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Equipos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                /*Equipo e = new Equipo();
                e.Nombre = collection.["Nombre"];
                e.Uniforme = collection["Uniforme"];
                db.Equipo.Add(e);
                db.SaveChanges();*/

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Equipos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
               

                // Update equipo with form posted values
                /*
                equipo.Nombre = Request.Form["Nombre"];
                equipo.Uniforme = Request.Form["Uniforme"];
                db.Save();
                */
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Equipos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                /*
                // TODO: Add delete logic here
                Equipo equipo = dinnerRepository.GetDinner(id);

                if (equipo == null)
                    return View("NotFound");

                dinnerRepository.Delete(equipo);
                dinnerRepository.Save();
                */
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
