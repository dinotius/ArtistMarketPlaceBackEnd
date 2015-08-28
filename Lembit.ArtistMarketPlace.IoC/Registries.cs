using Lembit.ArtistMarketPlace.RepositoryInterfaces;
using Autofac;
using Lembit.ArtistMarketPlace.SQLData;
//using Lembit.ArtistMarketPlace.MockVenueRepository;

namespace Lembit.ArtistMarketPlace.IoC
{
    public class BusinessRegistry : Module
    {

    }

    public class RepositoryRegistry : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VenueRepository>().As<IVenueRepository>().SingleInstance();
        }
    }
}
