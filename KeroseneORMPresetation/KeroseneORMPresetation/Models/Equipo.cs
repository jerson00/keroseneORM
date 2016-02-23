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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uniforme { get; set; }

        public static object getEquipos(IDataLink kConnection)
        {
            kConnection.Open();
            var equipos = kConnection.Raw("Select * from equipos").ToList();
            kConnection.Close();
            return equipos;
        }
        public static void insertEquipo(Equipo equipo, IDataLink kConnection)
        {
            kConnection.Open();
            var insert = kConnection.Raw("INSERT INTO [dbo].[equipos] ([nombre], [Uniforme]) VALUES ('" + equipo.Nombre + "','" + equipo.Uniforme + "')");
            insert.Execute();
            kConnection.Close();
        }

        public static void deleteEquipo(Equipo equipo, IDataLink kConnection)
        {
            kConnection.Open();
            var data = kConnection.Raw("DELETE FROM [dbo].[equipos] WHERE id = " + equipo.Id);
            data.Execute();
            kConnection.Close();
        }

        public static object getEquipoById(Equipo equipo, IDataLink kConnection)
        {
            kConnection.Open();
            var equipos = kConnection.Raw("Select * from equipos where id = " + equipo.Id).ToList();
            kConnection.Close();
            return equipos;
        }

        public static void updateEquipo(Equipo equipo, IDataLink kConnection)
        {
            kConnection.Open();
            var equipoEdit = kConnection.Raw("UPDATE[dbo].[equipos] SET[nombre] = '" + equipo.Nombre + "',[uniforme] = '" + equipo.Uniforme + "' WHERE id = " + equipo.Id);
            equipoEdit.Execute();
            kConnection.Close();
        }
    }
}
