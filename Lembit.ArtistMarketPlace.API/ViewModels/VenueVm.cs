using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Lembit.ArtistMarketPlace.DomainModels;
using Lembit.ArtistMarketPlace.RepositoryInterfaces;

namespace Lembit.ArtistMarketPlace.API.ViewModels
{
    public class VenueVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coordinate Coordinate { get; set; }
        public string VmTest { get; set; }
    }

    public interface IVenueVmMapper
    {
        VenueVm GetViewModel(int id);

        VenueVm ToViewModel(Venue entity);

        Venue SaveViewModel(VenueVm model);

        IEnumerable<VenueVm> GetList();
    }

    public class VenueVmMapper : IVenueVmMapper
    {
        private readonly IVenueRepository _venueRepository;

        public VenueVmMapper(IVenueRepository venueRepository)
        {
            _venueRepository = venueRepository;
        }

        public VenueVm GetViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public VenueVm ToViewModel(Venue entity)
        {
            throw new NotImplementedException();
        }

        public Venue SaveViewModel(VenueVm model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VenueVm> GetList()
        {
            MemberInitExpression bin = (MemberInitExpression)ViewModelProjection.Body;
            Debug.WriteLine(bin.NodeType);
            Debug.WriteLine(bin.Type);
            Debug.WriteLine(bin.Bindings);
            Debug.WriteLine(bin.NewExpression);

            return _venueRepository.GetAllVenues().Select(ViewModelProjection);
        }

        protected Expression<Func<Venue, VenueVm>> ViewModelProjection
        {
            get
            {
                return v => new VenueVm()
                {              
                    Id = v.Id,
                    Coordinate = v.Coordinate,
                    Name = v.Name,
                    VmTest = "Vm only prop"
                };
            }
        }
    }
}