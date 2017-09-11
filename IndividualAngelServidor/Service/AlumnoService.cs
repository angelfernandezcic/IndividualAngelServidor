using IndividualAngelServidor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualAngelServidor.Service
{
    public class AlumnoService : IAlumnoService
    {
        private IAlumnoRepository alumnoRepository;
        public AlumnoService(IAlumnoRepository _alumnoRepository)
        {
            this.alumnoRepository = _alumnoRepository;
        }

        public Alumno Get(long id)
        {
            return alumnoRepository.Get(id);
        }

        public IQueryable<Alumno> Get()
        {
            return alumnoRepository.Get();
        }

        public Alumno Create(Alumno alumno)
        {
            return alumnoRepository.Create(alumno);
        }

        public void Put(Alumno alumno)
        {
            alumnoRepository.Put(alumno);
        }

        public Alumno Delete(long id)
        {
            return alumnoRepository.Delete(id);
        }
    }
}