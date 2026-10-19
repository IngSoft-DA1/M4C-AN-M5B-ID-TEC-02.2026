using Domain;
using Microsoft.EntityFrameworkCore;
namespace DataAccess;

public class SqlContext : DbContext
{

    public DbSet<Movie> Movies { get; set; }
        
    public SqlContext(DbContextOptions<SqlContext> options) : base(options){ }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Configuraciones de la db
    }
    

}