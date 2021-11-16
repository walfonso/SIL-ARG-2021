using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Instituciones.Models
{
    public class SolicitudPersonal
    {
        public int idSolicitudPersonal { get; set; }
        public String puesto { get; set; }
        public int cantPuestos { get; set; }
        public string persaCargo { get; set; }
        public int cantPersonal { get; set; }
        public string tareaRealizar { get; set; }
        public string descripcion { get; set; }
        public string modalidadContratacion { get; set; }
        public string horarioTrabajo { get; set; }
        public string convenioTrabajo { get; set; }
        public Double remuneracion { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechafinalizacion { get; set; }
        public string estado { get; set; } 
    }
}