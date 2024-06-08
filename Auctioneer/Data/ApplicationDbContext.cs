using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Auctioneer.Models;

namespace Auctioneer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Listing> Listing { get; set; }
        public DbSet<Bid> Bid { get; set; }
        public DbSet<Comment> Comment { get; set; } 

    }
}
