using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CurriculumPowerRanger
{
    [Serializable]
    public class Persona
    {
        public string Cedula { get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set;}
        public string ColorFavorito { get; set; }
        public string CuentaTwitter { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string AnimalFavorito { get; set; }
        public string Direccion { get; set; }
        public string Enfermedad { get; set; }
        public string VehiculoFavorito { get; set; }
        [DefaultValue("No trabaja")]
        public string Trabajo { get; set;}
        [DefaultValue("No estudia")]
        public string Estudia { get; set; }
        [DefaultValue("No hay comentarios")]
        public string Comentario { get; set; }
    }

}
