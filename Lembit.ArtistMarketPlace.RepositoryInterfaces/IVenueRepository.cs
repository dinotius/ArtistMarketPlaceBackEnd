﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lembit.ArtistMarketPlace.DomainModels;

namespace Lembit.ArtistMarketPlace.RepositoryInterfaces
{
    public interface IVenueRepository
    {
        IQueryable<Venue> GetAllVenues();
    }
}
