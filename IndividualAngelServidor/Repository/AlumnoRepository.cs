using IndividualAngelServidor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndividualAngelServidor.Repository
{
    public class AlumnoRepository : IAlumnoRepository
    {
        public Alumno Create(Alumno alumno)
        {
            return ApplicationDbContext.applicationDbContext.Alumnos.Add(alumno);
        }

        public Alumno Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Alumnos.Find(id);
        }

        public IQueryable<Alumno> Get()
        {
            IList<Alumno> lista = new List<Alumno>(ApplicationDbContext.applicationDbContext.Alumnos);

            return lista.AsQueryable();
        }


        public void Put(Alumno alumno)
        {
            if (ApplicationDbContext.applicationDbContext.Alumnos.Count(e => e.Id == alumno.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(alumno).State = EntityState.Modified;
        }

        public Alumno Delete(long id)
        {
            Alumno alumno = ApplicationDbContext.applicationDbContext.Alumnos.Find(id);
            if (alumno == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Alumnos.Remove(alumno);
            return alumno;
        }
    }
}