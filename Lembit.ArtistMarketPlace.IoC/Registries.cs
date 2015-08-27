using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lembit.ArtistMarketPlace.RepositoryInterfaces;
using Lembit.ArtistMarketPlace.MockVenueRepository;
using Autofac;

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
