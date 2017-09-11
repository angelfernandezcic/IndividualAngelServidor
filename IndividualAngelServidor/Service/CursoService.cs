using IndividualAngelServidor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualAngelServidor.Service
{
    public class CursoService : ICursoService
    {
        private ICursoService cursoRepository;
        public CursoService(ICursoService _cursoRepository)
        {
            this.cursoRepository = _cursoRepository;
        }

        public Curso Get(long id)
        {
            return cursoRepository.Get(id);
        }

        public IQueryable<Curso> Get()
        {
            return cursoRepository.Get();
        }

        public Curso Create(Curso curso)
        {
            return cursoRepository.Create(curso);
        }

        public void Put(Curso curso)
        {
            cursoRepository.Put(curso);
        }

        public Curso Delete(long id)
        {
            return cursoRepository.Delete(id);
        }
    }
}