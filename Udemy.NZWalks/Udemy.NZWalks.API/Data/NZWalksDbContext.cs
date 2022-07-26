using Microsoft.EntityFrameworkCore;
using Udemy.NZWalks.API.Models.Domain;

namespace Udemy.NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }  
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
