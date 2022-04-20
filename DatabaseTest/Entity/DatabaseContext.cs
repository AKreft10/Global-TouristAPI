using DatabaseTest.Entity.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<AccommodationPhoto> AcommodationPhotos { get; set; }
        public DbSet<PlacePhoto> PlacePhotos { get; set; }
        public DbSet<AccommodationReview> AccommodationReviews { get; set; }
        public DbSet<PlaceReview> PlaceReviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // AccomodationPhoto
            modelBuilder.Entity<AccommodationPhoto>()
                .HasKey(ap => new { ap.PhotoId, ap.AccommodationId });

            modelBuilder.Entity<AccommodationPhoto>()
                .HasOne(ap => ap.Accommodation)
                .WithMany(p => p.Photos)
                .HasForeignKey(bc => bc.AccommodationId);

            modelBuilder.Entity<AccommodationPhoto>()
                .HasOne(ap => ap.Photo)
                .WithMany(c => c.AccomodationPhotos)
                .HasForeignKey(ap => ap.PhotoId);


            // AccomodationReview
            modelBuilder.Entity<AccommodationReview>()
                .HasKey(ar => new { ar.ReviewId, ar.AccommodationId });

            modelBuilder.Entity<AccommodationReview>()
                .HasOne(ar => ar.Accomodation)
                .WithMany(r => r.Reviews)
                .HasForeignKey(ar => ar.AccommodationId);

            modelBuilder.Entity<AccommodationReview>()
                .HasOne(ar => ar.Review)
                .WithMany(r => r.AccommodationReviews)
                .HasForeignKey(ar => ar.ReviewId);


            // PlacePhoto
            modelBuilder.Entity<PlacePhoto>()
                .HasKey(pp => new { pp.PhotoId, pp.PlaceId });

            modelBuilder.Entity<PlacePhoto>()
                .HasOne(pp => pp.Place)
                .WithMany(p => p.Photos)
                .HasForeignKey(pp => pp.PlaceId);

            modelBuilder.Entity<PlacePhoto>()
                .HasOne(pp => pp.Photo)
                .WithMany(p => p.PlacePhotos)
                .HasForeignKey(pp => pp.PhotoId);


            // PlaceReview
            modelBuilder.Entity<PlaceReview>()
                .HasKey(pr => new { pr.ReviewId, pr.PlaceId });

            modelBuilder.Entity<PlaceReview>()
                .HasOne(pr => pr.Place)
                .WithMany(p => p.Reviews)
                .HasForeignKey(pr => pr.PlaceId);

            modelBuilder.Entity<PlaceReview>()
                .HasOne(pr => pr.Review)
                .WithMany(p => p.PlaceReviews)
                .HasForeignKey(pr => pr.ReviewId);


            //Requirements
            new AddressConfig().Configure(modelBuilder.Entity<Address>());
            new ReviewConfig().Configure(modelBuilder.Entity<Review>());
            new PhotoConfig().Configure(modelBuilder.Entity<Photo>());
            new PlaceConfig().Configure(modelBuilder.Entity<Place>());
            new AccommodationConfig().Configure(modelBuilder.Entity<Accommodation>());
            base.OnModelCreating(modelBuilder);




        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("TeestDb"));
        }
    }
}
