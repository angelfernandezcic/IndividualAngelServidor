using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualAngelServidor
{
    public class Alumno
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Fecha { get; set; }
        public int Creditos { get; set; }
        public bool Beca { get; set; }
    }
}