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
using ProjetoYounder.Models;
using System.Web.Http.Cors;

namespace ProjetoYounder.Controllers
{
    public class ClienteController : ApiController
    {
        private YOUNDEREntities db = new YOUNDEREntities();

        // GET: api/Cliente
        public IQueryable<TBPessoaFisica> GetTBPessoaFisica()
        {
            return db.TBPessoaFisica;
        }

        // GET: api/Cliente/5
        [ResponseType(typeof(TBPessoaFisica))]
        public IHttpActionResult GetTBPessoaFisica(int id)
        {
            TBPessoaFisica tBPessoaFisica = db.TBPessoaFisica.Find(id);
            if (tBPessoaFisica == null)
            {
                return NotFound();
            }

            return Ok(tBPessoaFisica);
        }

        // PUT: api/Cliente/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTBPessoaFisica(int id, TBPessoaFisica tBPessoaFisica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tBPessoaFisica.idpessoafisica)
            {
                return BadRequest();
            }

            db.Entry(tBPessoaFisica).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TBPessoaFisicaExists(id))
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

        // POST: api/Cliente
        [ResponseType(typeof(TBPessoaFisica))]
        public IHttpActionResult PostTBPessoaFisica(TBPessoaFisica tBPessoaFisica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TBPessoaFisica.Add(tBPessoaFisica);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tBPessoaFisica.idpessoafisica }, tBPessoaFisica);
        }

        // DELETE: api/Cliente/5
        [ResponseType(typeof(TBPessoaFisica))]
        public IHttpActionResult DeleteTBPessoaFisica(int id)
        {
            TBPessoaFisica tBPessoaFisica = db.TBPessoaFisica.Find(id);
            if (tBPessoaFisica == null)
            {
                return NotFound();
            }

            db.TBPessoaFisica.Remove(tBPessoaFisica);
            db.SaveChanges();

            return Ok(tBPessoaFisica);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TBPessoaFisicaExists(int id)
        {
            return db.TBPessoaFisica.Count(e => e.idpessoafisica == id) > 0;
        }
    }
}