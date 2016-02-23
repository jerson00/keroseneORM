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
        public ActionResult Create(FormCollection formEquipo)
        {
            try
            {
                var objEquipo = new Equipo
                {
                    Nombre = formEquipo["nombre"],
                    Uniforme = formEquipo["uniforme"]
                };
                Equipo.insertEquipo(objEquipo, kConnection);
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Equipos/Edit/5
        public ActionResult Edit(int id)
        {
            var objEquipo = new Equipo
            {
                Id = id
            };

            ViewBag.equipos = Equipo.getEquipoById(objEquipo, kConnection);
            ViewBag.id = id;
            return View();
        }

        // POST: Equipos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {

                var objEquipo = new Equipo
                {
                    Id = id,
                    Nombre = collection["nombre"],
                    Uniforme = collection["uniforme"]
                };

                Equipo.updateEquipo(objEquipo, kConnection);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
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

                var objEquipo = new Equipo
                {
                    Id = id
                };

                Equipo.deleteEquipo(objEquipo, kConnection);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
