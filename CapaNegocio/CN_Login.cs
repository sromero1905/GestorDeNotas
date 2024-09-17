using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Login
    {
        private CD_Login obj_login = new CD_Login();
        public List<Alumno> listarAlumnos()
        {
            return obj_login.ListarAlumnos();
        }

        public List<Profesor> listarProf()
        {
            return obj_login.ListarProfesores();
        }

        public List<Admins> ListarAdmin()
        {
            return obj_login.ListarAdmin();
        }
    }
}
