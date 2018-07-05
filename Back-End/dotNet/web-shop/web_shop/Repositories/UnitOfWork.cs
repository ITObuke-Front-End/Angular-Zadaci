using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using web_shop.Models;
using Unity.Attributes;

namespace web_shop.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        [Dependency]
        public IGenericRepository<Artikal> ArtikalRepository { get; set; }

        [Dependency]
        public IGenericRepository<TipArtikla> TipArtiklaRepository { get; set; }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}