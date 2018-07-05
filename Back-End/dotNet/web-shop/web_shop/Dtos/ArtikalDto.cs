using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_shop.Models;

namespace web_shop.Dtos
{
    public class ArtikalDto
    {
        public ArtikalDto() { }
        public ArtikalDto(Artikal artikal)
        {
            Id = artikal.Id;
            Sifra = artikal.Sifra;
            Naziv = artikal.Naziv;
            Cena = artikal.Cena;
            Opis = artikal.Opis;
            SlikaUrl = artikal.SlikaUrl;
            TipArtiklaId = artikal.TipArtiklaId;
            TipArtiklaNaziv = artikal.TipArtikla.Naziv;
        }

        public int Id { get; set; }

        public String Sifra { get; set; }

        public String Naziv { get; set; }

        public Double Cena { get; set; }

        public String Opis { get; set; }

        public String SlikaUrl { get; set; }

        public int TipArtiklaId { get; set; }

        public String TipArtiklaNaziv { get; set; }
    }
}