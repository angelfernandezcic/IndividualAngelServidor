using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAngelServidor.Repository
{
    public interface IAlumnoRepository
    {
        Alumno Create(Alumno alumno);
        Alumno Delete(long id);
        IQueryable<Alumno> Get();
        Alumno Get(long id);
        void Put(Alumno alumno);
    }
}
