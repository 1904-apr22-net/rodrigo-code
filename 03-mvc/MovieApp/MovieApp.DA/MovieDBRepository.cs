using MovieApp.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.DA
{
    public class MovieDBRepository : IMovieRepository
    {
        private readonly MovieDBContext _dbContext;

        public MovieDBRepository(MovieDBContext dbContext) =>
           _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        /*
        public void Details(Movie movie)
        {
            //var id = _dbContext.Max(x => x.Id) + 1;
            //_dbContext.Movie = movie;
            //_dbContext.Add(movie);
        }

        public void DeleteMovie(int MovieId)
        {
           // _logger.Info($"Deleting restaurant with ID {restaurantId}");
            Entities.Movie entity = _dbContext.Movie.Find(MovieId);
            _dbContext.Remove(entity);
        }

        public void EditMovie(Movie movie)
        {
           // _logger.Info($"Updating restaurant with ID {restaurant.Id}");

            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            Entities.Movie currentMovie = _dbContext.Movie.Find(movie.Id);
            Restaurant newEntity = Mapper.Map(restaurant);

            _dbContext.Entry(currentEntity).CurrentValues.SetValues(newEntity);
        }
        */
        public IEnumerable<Movie> GetAll()
        {
            //return _dbContext.Movie;
            //return;
            throw new NotImplementedException();


        }

        public void Create(Movie movie)
        {
            var entity = new Entities.Movie
            {
                Id= movie.Id,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                //Genre = _dbContext.Find(movie.Id)
            };
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            throw new NotImplementedException();
        }

        public Genre GetGenreById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
