using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using Lembit.ArtistMarketPlace.IoC;


namespace Lembit.ArtistMarketPlace.API.Dependency_Resolution
{
    public class IoC
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            //Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterAssemblyModules(typeof(RepositoryRegistry).Assembly);

            // view model mappers
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("VmMapper"))
                .AsImplementedInterfaces();

            //Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}