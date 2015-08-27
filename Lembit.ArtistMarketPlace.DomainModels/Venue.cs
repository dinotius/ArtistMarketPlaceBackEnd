using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lembit.ArtistMarketPlace.DomainModels
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coordinate Coordinate { get; set; }
    }
}
