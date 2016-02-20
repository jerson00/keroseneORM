using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KeroseneORMPresetation.Models
{
    public class Estadio
    {

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
    }
}