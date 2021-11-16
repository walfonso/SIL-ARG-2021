using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Instituciones.Models
{
    public class Institucion
    {
       
        public int codigo { get; set; }
        public long cuit { get; set; }
        public string razonSocial { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public String email { get; set; }
         



    }

    public class empresa : Institucion
    {
        public String nomFantasia { get; set; }
        public String rubro { get; set; }
        public String actividadPrincipal { get; set; }
        public List<Referente> Contactos { get; set; }


    }
}