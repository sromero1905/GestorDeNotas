using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class NotaAlumno
    {
        public int IdNotaAlumno { get; set; }
        public int Nota { get; set; }
        public Materia oMateria { get; set; }
    }
}
