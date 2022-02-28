using Microsoft.EntityFrameworkCore;

namespace MealPrep.Models
{
  public class MealPrepContext : DbContext
  {
    public DbSet<Meal> Meals { get; set; }

    public MealPrepContext(DbContextOptions options) : base(options) { }
  }
}