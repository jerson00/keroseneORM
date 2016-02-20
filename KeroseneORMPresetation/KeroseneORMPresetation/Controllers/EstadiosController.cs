using KeroseneORMPresetation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeroseneORMPresetation.Controllers
{
    public class EstadiosController : Controller
    {
        // GET: Equipos
        int Id;
        string Nombre;
        string Localidad;
        public ActionResult Index()
        {
            var connection = MvcApplication.KeroseneConnection;
            return View();
        }

        // GET: Equipos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estadio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estadio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Estadio es = new Estadio();
                es.Nombre = collection["Nombre"];
                es.Localidad = collection["Localidad"];
                // db.Equipo.Add(e);
                // db.SaveChanges();

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
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
