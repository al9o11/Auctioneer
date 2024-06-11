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

        public async Task Add(Listing listing)
        {
            _context.Listing.Add(listing);
            await _context.SaveChangesAsync();
        }

        IQueryable<Listing> IListingService.GetAll()
        {
            var applicationDbContext = _context.Listing.Include(l => l.User);
            return applicationDbContext;
        }
    }
}
