using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MovieApp.DA.Entities;

namespace MovieApp.DA
{
    // Code First EF... we write the DBContext child class, and the entity in in its DBSets.
    //This class needs:
    //A) a zero parameter constructor

    public class MovieDBContext : DbContext
    {
        public MovieDBContext()
        {

        }
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // no need to call empty parent class implementation
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Id)
                    .ValueGeneratedOnAdd();
                //should configure an identity column

                entity.Property(m => m.Title)
                    .HasMaxLength(300);

                entity.HasOne(m => m.Genre);

                entity.Property(m => m.ReleaseDate)
                    .IsRequired()
                    .HasColumnType("DATETIME2");


            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(g => g.Name)
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Drama" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new
                {
                    Id = 1,
                    Title = "Star Wars IV",
                    ReleaseDate = DateTime.Today,
                    GenreId = 1 

                });
        }
    }
}
