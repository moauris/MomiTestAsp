using MySql.Data.EntityFramework;
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
        public BXSimDbContext(DbContextOptions<BXSimDbContext> opts) : base(opts) {}

        public DbSet<PracticeSet> tbl_practicesets { get; set; }
        public DbSet<Quiz> tbl_quizzes { get; set; }
        public DbSet<QuizScenario> tbl_scenarios { get; set; }
        public DbSet<Option> tbl_options { get; set; }
        public DbSet<RelQuizOption> rel_optionquiz { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
