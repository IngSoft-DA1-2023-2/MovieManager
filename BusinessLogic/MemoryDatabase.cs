using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MemoryDatabase
    {
        public List<Movie> Movies { get; set; }
        public List<Actor> Actors { get; set; }

        public MemoryDatabase() 
        {
            Movies = new List<Movie>();
            Actors = new List<Actor>();
            SeedData();
        }

        private void SeedData()
        {
            Movies.Add(new Movie { Id = 1, Title = "The Shwanshank", Director = "Frank Drabont", ReleaseYear = 1994 });
            Movies.Add(new Movie { Id = 2, Title = "The Godfather", Director = "Francis Coppola", ReleaseYear = 1972 });
            Movies.Add(new Movie { Id = 3, Title = "The Godfather 2", Director = "Francis Coppola", ReleaseYear = 1974 });
            Movies.Add(new Movie { Id = 4, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008 });
            Movies.Add(new Movie { Id = 5, Title = "The Lord of the Rings", Director = "Peter Jackson", ReleaseYear = 2003 });
            Movies.Add(new Movie { Id = 6, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994 });
            Movies.Add(new Movie { Id = 7, Title = "Schindler's List", Director = "Steven Spielberg", ReleaseYear = 1993 });
        }
    }
}
