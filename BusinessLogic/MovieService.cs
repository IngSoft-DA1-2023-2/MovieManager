using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MovieService
    {
        private readonly MovieManagerContext _database;

        public MovieService(MovieManagerContext database)
        {
            _database = database;
        }

        public List<Movie> GetMovies() 
        { 
            return _database.Movies.ToList();
        }

        public void AddMovie(Movie movie)
        {
            _database.Movies.Add(movie);
            _database.SaveChanges();
        }

        public void Update(int id, Movie updatedMovie)
        {
            var movie = _database.Movies.Where(movie => movie.Id == id).FirstOrDefault();

            if (movie != null)
            {
                movie.Title = updatedMovie.Title;
                movie.Director = updatedMovie.Director;
                movie.ReleaseYear = updatedMovie.ReleaseYear;

                _database.SaveChanges();
            }
        }
    }
}
