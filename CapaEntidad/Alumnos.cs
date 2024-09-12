using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Alumnos
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public string NumeroDocumento { get; set; }
        public Sede oSede { get; set; }
        public List<MateriaCursada> oMateria { get; set; }
        public List<NotaAlumno> oNotaAlumno { get; set; }

    }
}
