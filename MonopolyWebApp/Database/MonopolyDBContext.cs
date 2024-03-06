using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MonopolyWebApp.Data;
using MonopolyWebApp.Models;

namespace MonopolyWebApp.Database
{
    public class MonopolyDBContext : DbContext
    {
        
        public MonopolyDBContext(DbContextOptions<MonopolyDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(s =>
            {
                s.HasKey(k => k.CardId);
                s.HasData(
                    new Card()
                    {
                        CardId = 1,
                        Description = "Advance to Go (collect 200$)",
                        Action =  "advanceGo",
                        Price = 10
                    });
            });
        }
        public DbSet<Space> Spaces { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
