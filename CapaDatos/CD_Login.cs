using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Login
    {
        private List<T> ObtenerLista<T>(string query, Func<SqlDataReader, T> mapFunction)
        {
            List<T> lista = new List<T>();

            using (SqlConnection conn = new SqlConnection(Conexion.connexion))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(mapFunction(dr));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<T>();
                }
            }

            return lista;
        }

        public List<Alumno> ListarAlumnos()
        {
            string query = "select AlumnoId, Nombre, Apellido, Clave, NumeroDocumento, RoleId, Sede from Alumno";
            return ObtenerLista(query, dr => new Alumno
            {
                AlumnoId = Convert.ToInt32(dr["AlumnoId"]),
                Nombre = dr["Nombre"].ToString(),
                Apellido = dr["Apellido"].ToString(),
                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                Clave = dr["Clave"].ToString(),
                oSede = new Sede
                {
                    IdSede = Convert.ToInt32(dr["Sede"])
                },
                oRol = new Rol
                {
                    IdRol = Convert.ToInt32(dr["RoleId"])
                }
            });
        }

        public List<Admin> ListarAdmin()
        {
            string query = "select AdminId, Nombre, Apellido, NumeroDocumento, Password, RoleId from Admin";
            return ObtenerLista(query, dr => new Admin
            {
                AdminId = Convert.ToInt32(dr["AdminId"]),
                Nombre = dr["Nombre"].ToString(),
                Apellido = dr["Apellido"].ToString(),
                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                Password = dr["Password"].ToString(),
                oRol = new Rol
                {
                    IdRol = Convert.ToInt32(dr["RoleId"])
                }
            });
        }

        public List<Profesor> ListarProfesores()
        {
            string query = "select ProfesorId, Nombre, Apellido, Clave, Documento, MateriaId, Sede, RoleId from Profesor";
            return ObtenerLista(query, dr => new Profesor
            {
                IdProfesor = Convert.ToInt32(dr["ProfesorId"]),
                Nombre = dr["Nombre"].ToString(),
                Apellido = dr["Apellido"].ToString(),
                Documento = dr["Documento"].ToString(),
                Clave = dr["Clave"].ToString(),
                oSede = new Sede
                {
                    IdSede = Convert.ToInt32(dr["Sede"])
                },
                oMateria = new Materia
                {
                    IdMateria = Convert.ToInt32(dr["MateriaId"])
                },
                oRol = new Rol
                {
                    IdRol = Convert.ToInt32(dr["RoleId"])
                }
            });
        }
    }
}
