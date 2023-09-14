using Entites.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.IO;
using System.Reflection.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace Entites
{
    //DbContext
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public virtual DbSet<TourismPlaces> tourismPlaces { get; set; }
        public virtual DbSet<TrendingEvents> trendingEvents { get; set; }
        public virtual DbSet<FAQs> FAQs { get; set; }
        
        public virtual DbSet<Images> Images { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TourismPlaces>()
                .ToTable("TourismPlaces");

            modelBuilder.Entity<TrendingEvents>()
               .ToTable("TrendingEvents");

            modelBuilder.Entity<FAQs>()
            .ToTable("FAQs");

            modelBuilder.Entity<Images>()
            .ToTable("Images");

            modelBuilder.Entity<TourismPlaces>()
              .HasMany(e => e.images)
              .WithOne(e => e.tourism)
              .HasForeignKey(e => e.tourismPlaceId)
              .HasPrincipalKey(e => e.tourismPlaceId);

            modelBuilder.Entity<TrendingEvents>()
              .HasMany(e => e.Images)
              .WithOne(e => e.trending)
              .HasForeignKey(e => e.tredndingEventsId)
              .HasPrincipalKey(e => e.eventId);

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(e => e.UserId);
            modelBuilder.Entity<IdentityUserLogin<Guid>>().HasKey(e => e.UserId);
            modelBuilder.Entity<IdentityUserToken<Guid>>().HasKey(e => e.UserId);
        }

    }
}
