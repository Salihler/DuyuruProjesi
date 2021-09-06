using DuyuruProjesi.Core.Models;
using DuyuruProjesi.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DuyuruProjesi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration (new AnswerConfigurations());
            modelBuilder.ApplyConfiguration (new CategoryConfigurations());
            modelBuilder.ApplyConfiguration (new QuestionConfigurations());
            modelBuilder.ApplyConfiguration (new UserCopnfigurations());
        }
    }
}