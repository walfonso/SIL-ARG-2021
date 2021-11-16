using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloSeguridad.Models.Instituciones 
{
    
    public abstract class Persona
    {
        public int idPersona  { get; set; }
        public long documento { get; set; }
        public String apellidos { get; set; }
        public String nombres { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String genero { get; set; }
        public String domicilio { get; set; }
        public String telefono { get; set; }
        public String celular { get; set; }
        public String redes { get; set; }
        public empresa empresa { get; set; }



    }

    public class Empleado : Persona
    {
        public int legajo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public String cargo { get; set; }
        public String area{ get; set; }
        public String estado{ get; set; }
      

    }

    public class Postulante : Persona
    {
       
        public DateTime fechaAlta { get; set; }
      
        public String estado { get; set; }
     }

    public class Referente : Persona
    {
        public String area { get; set; }
        public String cargo { get; set; }


    }
}