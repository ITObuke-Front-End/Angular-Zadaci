using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web_shop.Models
{
    public class DropCreateModelCustom : DropCreateDatabaseIfModelChanges<DataAccessContext>
    {
        protected override void Seed(DataAccessContext context)
        {
            IList<TipArtikla> tipoviArtikala = new List<TipArtikla>
            {
                new TipArtikla() { Naziv = "Igrica", Opis = "" },
                new TipArtikla() { Naziv = "Konzola", Opis = "" },
                new TipArtikla() { Naziv = "Dodatak za konzolu", Opis = "" }
            };

            context.TipoviArtikala.AddRange(tipoviArtikala);
            context.SaveChanges();

            IList<Artikal> artikli = new List<Artikal>
            {
                new Artikal()
                {
                    Sifra = "257FRET3",
                    Cena = 319.99,
                    Naziv = "Nintendo Switch",
                    Opis = "Nintendo Switch is designed to go wherever you do, transforming from home console to portable system in a snap."
+ " So you get more time to play the games you love, however you like.",
                    SlikaUrl = "nintendoSwitch.jpg",
                    TipArtiklaId = 2
                },

                new Artikal()
                {
                    Sifra = "44F56D5T",
                    Cena = 58.99,
                    Naziv = "Super Mario Odyssey",
                    Opis = "Explore incredible places far from the Mushroom Kingdom as you join Mario and"
+ " his new ally Cappy on a massive, globe-trotting 3D adventure.",
                    SlikaUrl = "SuperMarioOdyssey.jpg",
                    TipArtiklaId = 1
                },

                new Artikal()
                {
                    Sifra = "2RS3TS4T",
                    Cena = 55.85,
                    Naziv = "The Legend of Zelda: Breath of the Wild",
                    Opis = "No kingdom. No memories. After a 100-year slumber, Link wakes up alone in a world he no longer remembers."
+ " Now the legendary hero must explore a vast and dangerous land...",
                    SlikaUrl = "Zelda.jpg",
                    TipArtiklaId = 1
                },

                new Artikal()
                {
                    Sifra = "9F3VCS31",
                    Cena = 399.99,
                    Naziv = "Playstation 4",
                    Opis = "INCREDIBLE GAMES. ENDLESS ENTERTAINMENT.",
                    SlikaUrl = "playstation4.jpg",
                    TipArtiklaId = 2
                },

                new Artikal()
                {
                    Sifra = "89FFCXS1",
                    Cena = -1,
                    Naziv = "Grand Theft Auto V",
                    Opis = "A place for reality TV stars, paparazziand faith healers - see for yourself...",
                    SlikaUrl = "gtaV.jpg",
                    TipArtiklaId = 1
                },

                new Artikal()
                {
                    Sifra = "9DV3DZQZ",
                    Cena = -1,
                    Naziv = "DUALSHOCK 4 wireless controller",
                    Opis = "",
                    SlikaUrl = "",
                    TipArtiklaId = 3
                },

                new Artikal()
                {
                    Sifra = "8DXL12D4",
                    Cena = 50.99,
                    Naziv = "Joy-Con",
                    Opis = "Add a splash of style to your Nintendo Switch console with Joy-Con controllers and Joy-Con straps.",
                    SlikaUrl = "nintendoJoyCon.jpg",
                    TipArtiklaId = 3
                }
            };

            context.Artikli.AddRange(artikli);
            context.SaveChanges();

        }
    }
}