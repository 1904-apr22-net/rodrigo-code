using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.BL;

namespace MovieApp.DA
{
    public class MovieRepository : IMovieRepository
    {
        private List<Movie> _data;

        public MovieRepository(List<Movie> data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }
        public void Create(Movie movie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _data;
        }
    }
}
