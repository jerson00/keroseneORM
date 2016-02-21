using Kerosene.ORM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeroseneORMPresetation.Models
{
    public class Estadio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }

        public static object getEstadios(IDataLink kConnection)
        {
            var estadios = kConnection.Raw("Select * from estadios").ToList();
            kConnection.Close();
            return estadios;
        }
    }
}