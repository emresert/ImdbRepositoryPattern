using ImdbData.Contexts;
using ImdbData.Models;
using ImdbData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ImdbService.Services
{
    public class MovieService : MovieCastRoleMappingService
    {

        public int GenerateMovieId(Movie obj)
        {
            Movie movieForInsert = new Movie();
            movieForInsert.movieLink = obj.movieLink;
            movieForInsert.movieName = obj.movieName;
            movieForInsert.movieYear = obj.movieYear;
            movieForInsert.movieImageUrl = obj.movieImageUrl;
            var movieRepository = new MovieRepository();
            movieRepository.Insert(movieForInsert);
            return movieForInsert.movieId;

        }
        public bool deleteMovie(Movie movie)
        {
            var movieRepository = new MovieRepository();
            movieRepository.Delete(movie);
            return true;
        }
        
        public Movie FindMovie(string _link)
        {
            var movieRepository = new MovieRepository();
            Movie selectedMovie = new Movie();
            selectedMovie = movieRepository.FindWithLink(x =>x.movieLink == _link);
            return selectedMovie;
        }


    }
}
