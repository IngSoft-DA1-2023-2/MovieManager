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
        private readonly MemoryDatabase _database;

        public MovieService(MemoryDatabase database)
        {
            _database = database;
        }

        public List<Movie> GetMovies() 
        { 
            return _database.Movies;
        }
    }
}
