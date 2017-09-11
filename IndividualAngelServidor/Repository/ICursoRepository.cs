using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualAngelServidor.Repository
{
    public interface ICursoRepository
    {
        Curso Create(Curso curso);
        Curso Delete(long id);
        IQueryable<Curso> Get();
        Curso Get(long id);
        void Put(Curso curso);
    }
}
