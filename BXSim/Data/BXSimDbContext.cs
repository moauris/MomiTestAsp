using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BXSim.Extensions;

namespace BXSim.Data
{
    public class BXSimDbContext : DbContext
    {
        public BXSimDbContext(DbContextOptions<BXSimDbContext> opts) : base(opts) {
            
            Database.EnsureCreated();
        }
        public DbSet<QuizScenario> QuizScenarios { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quiz>()
                .Property(q => q.Answers)
                .HasConversion(
                    v => v.ToJsonString(),
                    v => v.ToIEnumString()
                );
            modelBuilder.Entity<Quiz>()
                .Property(q => q.Options)
                .HasConversion(
                    v => v.ToJsonString(),
                    v => v.ToIEnumString()
                );
            modelBuilder.Entity<QuizScenario>()
                .HasMany(c => c.Quizzes);
        }
    }
}
