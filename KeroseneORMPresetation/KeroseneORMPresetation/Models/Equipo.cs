using Kerosene.ORM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeroseneORMPresetation.Models
{
    public class Equipo
    {
        public static object getEquipos(IDataLink kConnection)
        {
            var equipos = kConnection.Raw("Select * from equipos").ToList();
            kConnection.Close();
            return equipos;
        }
    }
}   