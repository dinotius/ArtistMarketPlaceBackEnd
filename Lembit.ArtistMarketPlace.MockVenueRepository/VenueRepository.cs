using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lembit.ArtistMarketPlace.DomainModels;
using Lembit.ArtistMarketPlace.RepositoryInterfaces;

namespace Lembit.ArtistMarketPlace.MockVenueRepository
{
    public class VenueRepository : IVenueRepository
    {
        private static IQueryable<Venue> _venues;

        static VenueRepository()
        {
            if (_venues == null)
                CreateMockVenueRepository();
        }

        private static void CreateMockVenueRepository()
        {
            List<Venue> tmp = new List<Venue>
            {
                new Venue()
                {
                    Id = 1,
                    Name = "The Bay View Mock Hotel",
                    Coordinate = new Coordinate()
                    {
                        Latitude = 198,
                        Longitude = 233
                    }
                },
                new Venue()
                {
                    Id = 2,
                    Name = "The Great Northern Mock",
                    Coordinate = new Coordinate()
                    {
                        Latitude = 877,
                        Longitude = 459
                    }
                },
                new Venue()
                {
                    Id = 3,
                    Name = "Strawberry Mock Hotel",
                    Coordinate = new Coordinate()
                    {
                        Latitude = 655,
                        Longitude = 899
                    }
                }
            };

            _venues = tmp.AsQueryable();
        }

        public IQueryable<Venue> GetAllVenues()
        {
            return _venues;
        }
    }
}
