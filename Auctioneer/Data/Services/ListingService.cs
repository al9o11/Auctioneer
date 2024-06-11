using Auctioneer.Models;
using Auctioneer.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Auctioneer.Data.Services
{

    public class ListingService : IListingService
    {
        private readonly ApplicationDbContext _context;

        public ListingService(ApplicationDbContext context)
        {
            _context = context;
        }
        IQueryable<Listing> IListingService.GetAll()
        {
            var applicationDbContext = _context.Listing.Include(l => l.User);
            return applicationDbContext;
        }
    }
}
