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
        public IDataLink Conection()
        {
            Kerosene.ORM.Direct.DataEngine.InitializeEngines();
            var connection = Kerosene.ORM.Direct.DataLink.Create("SqlClient", "Server=JERSON-PC\\SQLEXPRESS;Database=KeroseneDB;Integrated Security=true");
            connection.Open();
            return connection;
        }
    }
}