using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BackpackModel> Backpacks { get; set; }
        public DbSet<CharacterModel> Characters { get; set; }
        public DbSet<WeaponModel> Weapons { get; set; }
        public DbSet<FactionModel> Factions { get; set; }
    }
}