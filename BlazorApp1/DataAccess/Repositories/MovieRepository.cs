using Domain;

namespace DataAccess.Repositories;

public class MovieRepository
{
    private InMemoryDatabase _inMemoryDatabase;
    
    public MovieRepository(InMemoryDatabase inMemoryDatabase)
    {
        _inMemoryDatabase = inMemoryDatabase;
    }

    public void AddMovie(Movie movie)
    {
        _inMemoryDatabase.Movies.Add(movie);
    }

    public List<Movie> GetMovies()
    {
        return _inMemoryDatabase.Movies;
    }
}