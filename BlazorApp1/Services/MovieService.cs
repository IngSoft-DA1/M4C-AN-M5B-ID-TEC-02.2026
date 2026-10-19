using DataAccess.Repositories;
using Domain;

namespace Services;

public class MovieService
{
    private readonly MovieRepositorySql _movieRepository;

    public MovieService(MovieRepositorySql movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public void AddMovie(Movie movie)
    {
        //Hago validaciones
        _movieRepository.AddMovie(movie);
    }

    public List<Movie> GetMovies()
    {
        return _movieRepository.GetMovies();
    }
}