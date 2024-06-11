using Auctioneer.Models;

namespace Auctioneer.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);

    }
}
