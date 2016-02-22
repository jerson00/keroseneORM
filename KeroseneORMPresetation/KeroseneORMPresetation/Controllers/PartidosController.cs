using Kerosene.ORM.Core;
using KeroseneORMPresetation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeroseneORMPresetation.Controllers
{
    public class PartidosController : Controller
    {
        private IDataLink kConnection;
        public PartidosController()
        {
            KeroseneConection kc = new KeroseneConection();
            kConnection = kc.Conection();
        }
        // GET: Partidos
        public ActionResult Index()
        {
            ViewBag.partidos = Partidos.getPartidos(kConnection);
            return View();
        }

        // GET: Partidos/Create
        public ActionResult Create()
        {
            ViewBag.estadios = Partidos.getEstadios(kConnection);
            ViewBag.equipos = Partidos.getEquipos(kConnection);
            return View();
        }

        // POST: Partidos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ViewBag.message = null;
                var objPartido = new Partidos
                {
                    Equipo1 = Convert.ToInt32(collection["equipo1"]),
                    Marcador1 = Convert.ToInt32(collection["marcador1"]),
                    Equipo2 = Convert.ToInt32(collection["equipo2"]),
                    Marcador2 = Convert.ToInt32(collection["marcador2"]),
                    Estadio = Convert.ToInt32(collection["estadio"])
                };

                if (objPartido.Equipo1 == objPartido.Equipo2)
                {
                    ViewBag.message = "Debe seleccionar 2 equipos diferentes";
                    ViewBag.estadios = Partidos.getEstadios(kConnection);
                    ViewBag.equipos = Partidos.getEquipos(kConnection);
                    return View();
                }

                Partidos.insertPartido(objPartido, kConnection);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // POST: Partidos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Partidos.updatePartido(id, kConnection);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }
    }
}