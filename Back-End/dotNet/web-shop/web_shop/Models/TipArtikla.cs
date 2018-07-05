using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace web_shop.Models
{
    public class TipArtikla
    {
        public int Id { get; set; }

        public String Naziv { get; set; }

        public String Opis { get; set; }

        
        public ICollection<Artikal> Artikli { get; set; }

    }
}