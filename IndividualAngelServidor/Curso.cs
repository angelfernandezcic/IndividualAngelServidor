using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualAngelServidor
{
    public class Curso
    {
        public long Id { get; set; }
        public string Rama { get; set; }
        public string Carrera { get; set; }
        public int Anyo { get; set; }
        public int Creditos { get; set; }
        public int Alumnos { get; set; }
    }
}