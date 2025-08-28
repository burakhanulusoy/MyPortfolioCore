using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Entities;
using Proje1Denemesi.Entities;

namespace Proje1Denemesi.Context
{
    public class PortfolioContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ULUSOY;Database=PortfolioDBDeneme;integrated security=true;TrustServerCertificate=True");
              
        }



        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Expreince> Expreinces { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }

        






    }
}
