using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web_shop.Models
{
    public class DataAccessContext : DbContext
    {
        public DataAccessContext() : base("DataAccessConnection")
        {
            Database.SetInitializer<DataAccessContext>(new DropCreateModelCustom());
        }

        public DbSet<Artikal> Artikli { get; set; }
        public DbSet<TipArtikla> TipoviArtikala { get; set; }

    }
}