using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Permissions;
using System.Web.Http;

using Lembit.ArtistMarketPlace.DomainModels;
using Lembit.ArtistMarketPlace.MockVenueRepository;
using Lembit.ArtistMarketPlace.RepositoryInterfaces;

namespace Lembit.ArtistMarketPlace.API.Controllers
{
    public class VenuesController : ApiController
    {
        private readonly IVenueRepository _venueRepository;

        public VenuesController()
        {

        }

        
        public VenuesController(IVenueRepository venueRepository)
        {
            _venueRepository = venueRepository;
        }

        // GET api/venues
        [Authorize]
        public IEnumerable<Venue> Get()
        {
            return _venueRepository.GetAllVenues();
        }

        // GET api/venues/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/venues
        public void Post([FromBody]string value)
        {
        }

        // PUT api/venues/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/venues/5
        public void Delete(int id)
        {
        }
    }
}
