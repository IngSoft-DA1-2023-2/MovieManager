using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MovieManagerContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public MovieManagerContext(DbContextOptions<MovieManagerContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "The Shwanshank", Director = "Frank Drabont", ReleaseYear = 1994 },
                new Movie { Id = 2, Title = "The Godfather", Director = "Francis Coppola", ReleaseYear = 1972 },
                new Movie { Id = 3, Title = "The Godfather 2", Director = "Francis Coppola", ReleaseYear = 1974 },
                new Movie { Id = 4, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008 },
                new Movie { Id = 5, Title = "The Lord of the Rings", Director = "Peter Jackson", ReleaseYear = 2003 },
                new Movie { Id = 6, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994 },
                new Movie { Id = 7, Title = "Schindler's List", Director = "Steven Spielberg", ReleaseYear = 1993 }
            );

            modelBuilder.Entity<Actor>().HasData(
                new Actor { Name="Leonardo", LastName="Di Caprio", Age=50 }
            );

            modelBuilder.Entity<Actor>().HasKey(x => x.Name);
            modelBuilder.Entity<Movie>().HasMany(x => x.Categories).WithMany();
        }
    }
}
