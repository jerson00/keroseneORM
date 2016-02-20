using Kerosene.ORM.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace KeroseneORMPresetation.Models
{
    public class KeroseneConection
    {
        public static IDbConnection Conection()
        {
            Kerosene.ORM.Direct.DataEngine.InitializeEngines();

            var link = Kerosene.ORM.Direct.DataLink.Create("SqlClient",
                "Server=ESTEBAN-PC\\SQLSERVER;Database=KeroseneDB;Integrated Security=true");

            link.Open();
            return link.DbConnection;

        }
    }
}