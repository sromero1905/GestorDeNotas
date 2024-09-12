using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Login
    {
        public List<Alumnos> listar()
        {
            List<Alumnos> lista = new List<Alumnos>();

            using (SqlConnection conn = new SqlConnection(Conexion.connexion))
            {
                try
                {
                    string query = "select AlumnoId, Nombre, Apellido,Clave,NumeroDocumento, Sede from Alumno";

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Alumnos
                                {
                                    AlumnoId = Convert.ToInt32(dr["AlumnoId"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    Apellido = dr["Apellido"].ToString(),
                                    NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                    Clave = dr["Clave"].ToString(),
                                    oSede = new Sede
                                    {
                                        IdSede = Convert.ToInt32(dr["Sede"]) 
                                    }

                                });
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    lista = new List<Alumnos>();
                }
                return lista;
            }

        }
       
        
    }
}
