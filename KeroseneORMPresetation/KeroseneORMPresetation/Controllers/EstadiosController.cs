using Kerosene.ORM.Core;
using KeroseneORMPresetation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeroseneORMPresetation.Controllers
{
    public class EstadiosController : Controller
    {
        private IDataLink kConnection;
        // GET: Equipos
        public EstadiosController()
        {
            KeroseneConection kc = new KeroseneConection();
            kConnection = kc.Conection();
        }
        public ActionResult Index()
        {
            ViewBag.estadios = Estadio.getEstadios(kConnection);
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
        public ActionResult Create(FormCollection formEstadio)
        {
            try
            {
                var objEstadio = new Estadio
                {
                    Nombre = formEstadio["nombre"],
                    Localidad = formEstadio["localidad"]
                };
                Estadio.insertEstadio(objEstadio, kConnection);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Estadios/Edit/5
        public ActionResult Edit(int id)
        {
            var objEstadio = new Estadio
            {
                Id = id
            };

            ViewBag.estadios = Estadio.getEstadioById(objEstadio, kConnection);
            ViewBag.id = id;
            return View();
        }

        // POST: Estadios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var objEstadio = new Estadio
                {
                    Id = id,
                    Nombre = collection["nombre"],
                    Localidad = collection["localidad"]
                };

                Estadio.updateEstadio(objEstadio, kConnection);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Equipos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estadios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var objEstadio = new Estadio
                {
                    Id = id
                };

                Estadio.deleteEstadio(objEstadio, kConnection);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
