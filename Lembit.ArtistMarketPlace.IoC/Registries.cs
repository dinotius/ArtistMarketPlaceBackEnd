using Lembit.ArtistMarketPlace.RepositoryInterfaces;
using Autofac;
using Lembit.ArtistMarketPlace.SQLData;
//using Lembit.ArtistMarketPlace.MockVenueRepository;
using Lembit.ArtistMarketPlace.InfrastructureInterfaces;
using Lembit.ArtistMarketPlance.Infrastructure;

namespace Lembit.ArtistMarketPlace.IoC
{
    public class BusinessRegistry : Module
    {

    }

    public class RepositoryRegistry : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Domain
            builder.RegisterType<VenueRepository>().As<IVenueRepository>().SingleInstance();
            //builder.RegisterType<VenueRepository>().As<IVenueRepository>().InstancePerDependency();

            //Infrastructure
            builder.RegisterType<ConsoleLogger>().As<ILogger>().SingleInstance();
        }
    }
}
