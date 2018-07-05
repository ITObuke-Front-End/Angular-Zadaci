using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using web_shop.Models;
using web_shop.Repositories;

namespace web_shop.Controllers
{
    public class TipArtiklaController : ApiController
    {

        private IUnitOfWork db;

        public TipArtiklaController(IUnitOfWork db)
        {
            this.db = db;
        }

        public IHttpActionResult GetAll()
        {
            return Ok(db.TipArtiklaRepository.Get());
        }

        [ResponseType(typeof(TipArtikla))]
        public IHttpActionResult GetById(int id)
        {
            return Ok(db.TipArtiklaRepository.GetByID(id));
        }

        [ResponseType(typeof(TipArtikla))]
        public IHttpActionResult PostTipArtikla(TipArtikla tipArtikla)
        {
            db.TipArtiklaRepository.Insert(tipArtikla);
            db.Save();
            return Ok(tipArtikla);
        }

        [ResponseType(typeof(TipArtikla))]
        public IHttpActionResult PutTipArtikla(int id, TipArtikla tipArtikla)
        {
            var loadedTipArtikla = db.TipArtiklaRepository.GetByID(id);
            loadedTipArtikla.Naziv = tipArtikla.Naziv;
            loadedTipArtikla.Opis = tipArtikla.Opis;
            db.TipArtiklaRepository.Update(loadedTipArtikla);
            db.Save();

            return Ok(tipArtikla);
        }

        [ResponseType(typeof(TipArtikla))]
        public IHttpActionResult DeleteTipArtikla(int id)
        {
            var tipArtiklaDb = db.TipArtiklaRepository.GetByID(id);
            db.TipArtiklaRepository.Delete(tipArtiklaDb);
            db.Save();

            return Ok(tipArtiklaDb);
        }

    }
}
