using FilmCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace FilmCrud.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
     
        public virtual DbSet<Film> Films { get; set; }
    }
}