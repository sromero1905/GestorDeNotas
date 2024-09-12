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
        private CD_Login obcj_login = new CD_Login();
        public List<Alumnos> listar()
        {
            return obcj_login.listar();
        }
    }
}
