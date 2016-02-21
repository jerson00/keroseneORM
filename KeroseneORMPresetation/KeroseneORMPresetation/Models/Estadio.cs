﻿using Kerosene.ORM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeroseneORMPresetation.Models
{
    public class Estadio
    {
        public static object getEstadios(IDataLink kConnection)
        {
            var estadios = kConnection.Raw("Select * from estadios").ToList();
            kConnection.Close();
            return estadios;
        }
    }
}