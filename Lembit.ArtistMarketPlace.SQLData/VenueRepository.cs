﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lembit.ArtistMarketPlace.DomainModels;
using Lembit.ArtistMarketPlace.RepositoryInterfaces;

namespace Lembit.ArtistMarketPlace.SQLData
{
    public class VenueRepository : IVenueRepository
    {
        private static List<Venue> _venues;

        static VenueRepository()
        {
            if (_venues == null)
                CreateMockVenueRepository();
        }

        private static void CreateMockVenueRepository()
        {
            _venues = new List<Venue>
            {
                new Venue()
                {
                    Id = 1,
                    Name = "The Bay View Hotel",
                    Coordinate = new Coordinate()
                    {
                        Latitude = 198,
                        Longitude = 233
                    }
                },
                new Venue()
                {
                    Id = 2,
                    Name = "The Great Northern",
                    Coordinate = new Coordinate()
                    {
                        Latitude = 877,
                        Longitude = 459
                    }
                },
                new Venue()
                {
                    Id = 3,
                    Name = "Strawberry Hotel",
                    Coordinate = new Coordinate()
                    {
                        Latitude = 655,
                        Longitude = 899
                    }
                }
            };


        }

        public List<Venue> GetAllVenues()
        {
            return _venues;
        }
    }
}
