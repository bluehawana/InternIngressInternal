using Microsoft.EntityFrameworkCore;
using Intern.Domain.Entities;

namespace InternIngressInternal.Intern.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<CV> CVs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CV>()
                .Property(p => p.Name)
                .IsRequired()                 // Makes the Name column required
                .HasMaxLength(100);            // Set a maximum length for the Name column

            modelBuilder.Entity<CV>()
                .Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);

            // If you had a one-to-many relationship between CV and Skill, for instance:
            modelBuilder.Entity<CV>()
                .HasMany(c => c.Skills)      // Assuming CV has a collection property named Skills
                .WithOne()                   // This would be WithOne(s => s.CV) if Skill had a CV property
                .HasForeignKey("CVId");      // Name of the foreign key column in the Skill table

            // Configuring the Skill entity
            modelBuilder.Entity<Skill>()
                .Property(p => p.SkillName)  // Assuming the Skill entity has a SkillName property
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Experience>()
                .Property(p => p.CompanyName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Project>()
                .Property(p => p.ProjectName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Education>()
                .Property(p => p.SchoolName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
