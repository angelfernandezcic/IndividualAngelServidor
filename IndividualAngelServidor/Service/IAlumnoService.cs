using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAngelServidor.Service
{
    public interface IAlumnoService
    {
        Alumno Create(Alumno alumno);
        Alumno Delete(long id);
        IQueryable<Alumno> Get();
        Alumno Get(long id);
        void Put(Alumno alumno);
    }
}
