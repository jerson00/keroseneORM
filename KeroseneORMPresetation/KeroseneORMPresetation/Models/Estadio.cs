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
            kConnection.Open();
            var estadios = kConnection.Raw("Select * from estadios").ToList();
            kConnection.Close();
            return estadios;
        }

        public static void insertEstadio(Estadio estadio, IDataLink kConnection)
        {
            kConnection.Open();
            var insert = kConnection.Raw("INSERT INTO [dbo].[estadios] ([nombre], [localidad]) VALUES ('"+ estadio.Nombre +"','"+ estadio.Localidad +"')");
            insert.Execute();
            kConnection.Close();
        }

        public static void deleteEstadio(Estadio estadio, IDataLink kConnection)
        {
            kConnection.Open();
            var data = kConnection.Raw("DELETE FROM [dbo].[estadios] WHERE id = " + estadio.Id);
            data.Execute();
            kConnection.Close();
        }

        public static object getEstadioById(Estadio estadio, IDataLink kConnection)
        {
            kConnection.Open();
            var estadios = kConnection.Raw("Select * from estadios where id = " + estadio.Id).ToList();
            kConnection.Close();
            return estadios;
        }

        public static void updateEstadio(Estadio estadio, IDataLink kConnection)
        {
            kConnection.Open();
            var estadioEdit = kConnection.Raw("UPDATE[dbo].[estadios] SET[nombre] = '" + estadio.Nombre + "',[localidad] = '" + estadio.Localidad + "' WHERE id = " + estadio.Id);
            estadioEdit.Execute();
            kConnection.Close();
        }
    }
}