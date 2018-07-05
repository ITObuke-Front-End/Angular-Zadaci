using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_shop.Models;

namespace web_shop.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<Artikal> ArtikalRepository { get;}
        IGenericRepository<TipArtikla> TipArtiklaRepository { get; }


        void Save();
    }
}
