using System.Data.Entity;
using System.Web.Http;
using web_shop.Models;
using web_shop.Repositories;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace web_shop
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<DbContext, DataAccessContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IGenericRepository<Artikal>, GenericRepository<Artikal>>();
            container.RegisterType<IGenericRepository<TipArtikla>, GenericRepository<TipArtikla>>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}