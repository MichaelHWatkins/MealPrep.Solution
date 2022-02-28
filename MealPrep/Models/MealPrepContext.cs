using Microsoft.EntityFrameworkCore;

namespace MealPrep.Models
{
  public class MealPrepContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public MealPrepContext(DbContextOptions options) : base(options) { }
  }
}