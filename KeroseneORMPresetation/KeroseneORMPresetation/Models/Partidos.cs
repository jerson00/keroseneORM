using Kerosene.ORM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeroseneORMPresetation.Models
{
    public class Partidos
    {
        public int Id { get; set; }
        public int Equipo1 { get; set; }
        public int Marcador1 { get; set; }
        public int Equipo2 { get; set; }
        public int Marcador2 { get; set; }
        public int Estadio { get; set; }

        public static object getPartidos(IDataLink kConnection)
        {
            kConnection.Open();
            var partidos = kConnection.Raw("select p.id, e.nombre as equipo1, p.marcador1, e2.nombre as equipo2, p.marcador2, es.nombre as estadio from [keroseneDB].[dbo].[partidos] p  inner join[keroseneDB].[dbo].[equipos] e on e.id = p.equipo1 inner join[keroseneDB].[dbo].[equipos] e2 on e2.id = p.equipo2 inner join[keroseneDB].[dbo].[estadios] es on es.id = p.estadio").ToList();
            kConnection.Close();
            return partidos;
        }

        public static object updatePartido(int id, IDataLink kConnection)
        {
            kConnection.Open();
            Random random = new Random();
            int marcador1 = random.Next(0, 7);
            int marcador2 = random.Next(0, 7);
            var partidos = kConnection.Raw("UPDATE [dbo].[partidos] SET[marcador1] = " + marcador1 + ", [marcador2] = " + marcador2 + " WHERE[id] = " + id);
            partidos.Execute();
            kConnection.Close();
            return partidos;
        }

        public static object getEquipos(IDataLink kConnection)
        {
            kConnection.Open();
            var equipos = kConnection.Raw("select * from equipos").ToList();
            kConnection.Close();
            return equipos;
        }

        public static object getEstadios(IDataLink kConnection)
        {
            kConnection.Open();
            var estadios = kConnection.Raw("select * from estadios").ToList();
            kConnection.Close();
            return estadios;
        }

        public static void insertPartido(Partidos partido, IDataLink kConnection)
        {
            kConnection.Open();
            var insert = kConnection.Raw("INSERT INTO [dbo].[partidos] ([equipo1], [marcador1], [equipo2], [marcador2], [estadio]) VALUES("+ partido.Equipo1 +", null, "+ partido.Equipo2 +", null, " + partido.Estadio + ")");
            insert.Execute();
            kConnection.Close();
        }
    }

}