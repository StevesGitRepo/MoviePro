using MoviePro.Enums;
using MoviePro.Models.TMDB;

namespace MoviePro.Services
{
    public interface IRemoterMovieService
    {
        Task<MovieDetail> MovieDetailAsync(int id);
        Task<MovieSearch> SearchMoviesAsync(MovieCategory category, int count);
        Task<ActorDetail> ActorDetailAsync(int id);
    }
}
