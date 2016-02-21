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
    }
}