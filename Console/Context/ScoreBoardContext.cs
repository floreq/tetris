using Microsoft.EntityFrameworkCore;

namespace Console.Context
{
    public class ScoreBoardContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost, 1433;Initial Catalog=Tetris;Persist Security Info=True;User ID=sa;Password=Your_password123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
