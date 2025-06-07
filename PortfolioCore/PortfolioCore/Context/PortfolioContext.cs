using Microsoft.EntityFrameworkCore;
using PortfolioCore.Entities;

namespace PortfolioCore.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-UDEPILDO\\SQLEXPRESS; initial Catalog=PortfolioDb; integrated security=true;");
        }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Connect> Connects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<MyJob> MyJobs { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        

    }
}
