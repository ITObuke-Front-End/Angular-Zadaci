using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using web_shop.Dtos;

namespace web_shop.Models
{
    public class Artikal
    {
        public Artikal() {}

        public Artikal(ArtikalDto artikalDto)
        {
            Id = artikalDto.Id;
            Sifra = artikalDto.Sifra;
            Naziv = artikalDto.Naziv;
            Opis = artikalDto.Opis;
            SlikaUrl = artikalDto.SlikaUrl;
            Cena = artikalDto.Cena;
        }

        public int Id { get; set; }

        public String Sifra { get; set; }

        public String Naziv { get; set; }

        public Double Cena { get; set; }

        public String Opis { get; set; }

        public String SlikaUrl { get; set; }

        [ForeignKey("TipArtikla")]
        public int TipArtiklaId { get; set; }


        [ForeignKey("TipArtiklaId")]
        public virtual TipArtikla TipArtikla { get; set; }
    }
}