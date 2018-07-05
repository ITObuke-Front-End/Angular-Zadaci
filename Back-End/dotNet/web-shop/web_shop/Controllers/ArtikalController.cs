using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using web_shop.Dtos;
using web_shop.Models;
using web_shop.Repositories;

namespace web_shop.Controllers
{
    public class ArtikalController : ApiController
    {
        private IUnitOfWork db;

        public ArtikalController(IUnitOfWork db)
        {
            this.db = db;
        }

        [ResponseType(typeof(ArtikalDto))]
        public IHttpActionResult GetAll(String naziv="")
        {
            List<ArtikalDto> artikalDtoList = new List<ArtikalDto>();
            
            if (naziv.Equals(""))
            {
                foreach (Artikal artikal in db.ArtikalRepository.Get())
                {
                    artikalDtoList.Add(new ArtikalDto(artikal));
                }
            } else
            {
                foreach (Artikal artikal in db.ArtikalRepository.Get(x => x.Naziv.ToLower().Contains(naziv.ToLower())))
                {
                    artikalDtoList.Add(new ArtikalDto(artikal));
                }
            }

            return Ok(artikalDtoList);

        }

        [ResponseType(typeof(ArtikalDto))]
        public IHttpActionResult GetById(int id)
        {
            return Ok(new ArtikalDto(db.ArtikalRepository.Get(a => a.Id == id, includeProperties: "TipArtikla").FirstOrDefault()));
        }

        [ResponseType(typeof(ArtikalDto))]
        public IHttpActionResult PostArtikal(ArtikalDto artikalDto)
        {
            Artikal artikal = new Artikal(artikalDto);
            db.ArtikalRepository.Insert(artikal);
            db.Save();
            return Ok(new ArtikalDto(db.ArtikalRepository.Get(a => a.Id == artikal.Id, includeProperties: "TipArtikla").FirstOrDefault()));
        }

        [ResponseType(typeof(ArtikalDto))]
        public IHttpActionResult PutArtikal(int id, ArtikalDto artikal)
        {
            var loadedArtikal = db.ArtikalRepository.GetByID(id);
            loadedArtikal.Naziv = artikal.Naziv;
            loadedArtikal.Sifra = artikal.Sifra;
            loadedArtikal.Cena = artikal.Cena;
            loadedArtikal.Opis = artikal.Opis;
            loadedArtikal.SlikaUrl = artikal.SlikaUrl;
            loadedArtikal.TipArtiklaId = artikal.TipArtiklaId;
            db.ArtikalRepository.Update(loadedArtikal);
            db.Save();

            return Ok(artikal);
        }

        [ResponseType(typeof(ArtikalDto))]
        public IHttpActionResult DeleteArtikal(int id)
        {
            var artikalDb = db.ArtikalRepository.Get(a => a.Id == id, includeProperties: "TipArtikla").FirstOrDefault();
            ArtikalDto artikalDto = new ArtikalDto(artikalDb);

            db.ArtikalRepository.Delete(id);
            db.Save();

            return Ok(artikalDto);
        }
    }
}
