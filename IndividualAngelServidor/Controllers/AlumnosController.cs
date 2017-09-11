using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using IndividualAngelServidor;
using IndividualAngelServidor.Models;
using System.Web.Http.Cors;

namespace IndividualAngelServidor.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AlumnosController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Alumnos
        public IQueryable<Alumno> GetAlumnos()
        {
            return db.Alumnos;
        }

        // GET: api/Alumnos/5
        [ResponseType(typeof(Alumno))]
        public IHttpActionResult GetAlumno(long id)
        {
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }

            return Ok(alumno);
        }

        // PUT: api/Alumnos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAlumno(long id, Alumno alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != alumno.Id)
            {
                return BadRequest();
            }

            db.Entry(alumno).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Alumnos
        [ResponseType(typeof(Alumno))]
        public IHttpActionResult PostAlumno(Alumno alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Alumnos.Add(alumno);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = alumno.Id }, alumno);
        }

        // DELETE: api/Alumnos/5
        [ResponseType(typeof(Alumno))]
        public IHttpActionResult DeleteAlumno(long id)
        {
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }

            db.Alumnos.Remove(alumno);
            db.SaveChanges();

            return Ok(alumno);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AlumnoExists(long id)
        {
            return db.Alumnos.Count(e => e.Id == id) > 0;
        }
    }
}