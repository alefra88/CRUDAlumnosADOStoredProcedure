using CRUDAlumnosADOStoredProcedure.Ent;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDAlumnosADOStoredProcedure.DaL
{
    public class DAlumnos
    {
        private string _DBConnection;
        public DAlumnos() { _DBConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ToString(); }
        string _query;
        SqlCommand _cmd;

        public List<Alumnos> Consultar()
        {
            List<Alumnos> lst = new List<Alumnos>();
            _query = $"Consultar";
            using (SqlConnection conn = new SqlConnection(_DBConnection))
            {
                _cmd = new SqlCommand(_query, conn);
                _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id", -1);
                conn.Open();
                SqlDataReader reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new Alumnos()
                    {
                        Id = Convert.ToInt16(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        PrimerApellido = reader["primerApellido"].ToString(),
                        SegundoApellido = reader["segundoApellido"].ToString(),
                        Correo = reader["correo"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                        Curp = reader["curp"].ToString(),
                        SueldoMensual = reader["sueldoMensual"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["sueldoMensual"]),
                        IdEstadoOrigen = Convert.ToInt16(reader["idEstadoOrigen"]),
                        IdEstatus = Convert.ToInt16(reader["idEstatus"])
                    }
                        );
                }
                return lst;
            }
        }
    }
}