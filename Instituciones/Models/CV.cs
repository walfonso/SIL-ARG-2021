using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Instituciones.Models
{
    public class CV
    {
        public int idCV { get; set; }
        public List<Postulacion> postulaciones { get; set; }
        public List<AntecedenteLaboral> antLaborales { get; set; }
        public List<Educacion> educacion { get; set; }
        public InfoComplementaria infoComp { get; set; }
    }
}