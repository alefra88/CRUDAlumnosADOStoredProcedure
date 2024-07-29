using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDAlumnosADOStoredProcedure.Ent
{
    public class Alumnos
    {
        public Alumnos()
        {
        }

        public Alumnos(int id, string nombre, string primerApellido, string segundoApellido, string correo, string telefono, DateTime fechaNacimiento, string curp, decimal sueldoMensual, int idEstadoOrigen, int idEstatus)
        {
            Id = id;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Correo = correo;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Curp = curp;
            SueldoMensual = sueldoMensual;
            IdEstadoOrigen = idEstadoOrigen;
            IdEstatus = idEstatus;
        }

        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo {  get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Curp {  get; set; }
        public decimal SueldoMensual { get; set; }
        public int IdEstadoOrigen {  get; set; }
        public int IdEstatus { get; set; }

    }
}