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
            var connection = Kerosene.ORM.Direct.DataLink.Create("SqlClient", "Server=ESTEBAN-PC\\SQLSERVER;Database=KeroseneDB;Integrated Security=true");
            return connection;
        }
    }
}