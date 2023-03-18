using MoviePro.Models.Database;
using MoviePro.Models.TMDB;

namespace MoviePro.Services
{
    public interface IDataMappingService
    {
        Task<Movie> MapMovieDetailAsync(MovieDetail movie);
        ActorDetail MapActorDetail(ActorDetail actor);
    }
}
