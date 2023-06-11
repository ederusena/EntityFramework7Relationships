using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BackpackModel> Backpack { get; set; }
        public DbSet<CharacterModel> Character { get; set; }
    }
}