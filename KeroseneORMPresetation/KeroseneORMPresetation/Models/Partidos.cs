using Kerosene.ORM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeroseneORMPresetation.Models
{
    public class Partidos
    {
        public static object getPartidos(IDataLink kConnection)
        {
            var partidos = kConnection.Raw("select p.id, e.nombre as equipo1, p.marcador1, e2.nombre as equipo2, p.marcador2, es.nombre as estadio from [keroseneDB].[dbo].[partidos] p  inner join[keroseneDB].[dbo].[equipos] e on e.id = p.equipo1 inner join[keroseneDB].[dbo].[equipos] e2 on e2.id = p.equipo2 inner join[keroseneDB].[dbo].[estadios] es on es.id = p.estadio").ToList();
            kConnection.Close();
            return partidos;
        }
    }
}