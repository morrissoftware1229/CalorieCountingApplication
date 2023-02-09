using Microsoft.EntityFrameworkCore;

namespace CalorieCountingApplication.Models
{
    public class CalorieCountingApplicationContext : DbContext
    {
        public CalorieCountingApplicationContext(DbContextOptions<CalorieCountingApplicationContext> options) : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<FoodEntry> FoodEntries { get; set; }
        public DbSet<ExerciseEntry> ExerciseEntries { get; set; }
    }
}
