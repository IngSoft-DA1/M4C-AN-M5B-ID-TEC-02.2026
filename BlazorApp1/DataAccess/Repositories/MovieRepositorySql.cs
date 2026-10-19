using Domain;

namespace DataAccess.Repositories;

public class MovieRepositorySql
{
    private SqlContext _context;

    public MovieRepositorySql(SqlContext context)
    {
        _context = context;
    }

    public void AddMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    public List<Movie> GetMovies()
    {
        return _context.Movies.ToList();
    }


}