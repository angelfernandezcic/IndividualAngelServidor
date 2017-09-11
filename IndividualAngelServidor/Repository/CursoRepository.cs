using IndividualAngelServidor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndividualAngelServidor.Repository
{
    public class CursoRepository : ICursoRepository
    {
        public Curso Create(Curso curso)
        {
            return ApplicationDbContext.applicationDbContext.Cursos.Add(curso);
        }

        public Curso Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Cursos.Find(id);
        }

        public IQueryable<Curso> Get()
        {
            IList<Curso> lista = new List<Curso>(ApplicationDbContext.applicationDbContext.Cursos);

            return lista.AsQueryable();
        }


        public void Put(Curso curso)
        {
            if (ApplicationDbContext.applicationDbContext.Cursos.Count(e => e.Id == curso.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(curso).State = EntityState.Modified;
        }

        public Curso Delete(long id)
        {
            Curso curso = ApplicationDbContext.applicationDbContext.Cursos.Find(id);
            if (curso == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Cursos.Remove(curso);
            return curso;
        }
    }
}