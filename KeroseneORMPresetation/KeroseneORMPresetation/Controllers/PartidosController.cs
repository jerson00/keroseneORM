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

        // POST: Equipos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var cmd = kConnection.Update(x => x.Partidos).Where(x => x.Id == id).Columns(x => x.Marcador1 = 5,x => x.Marcador2 = 4);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }
    }
}