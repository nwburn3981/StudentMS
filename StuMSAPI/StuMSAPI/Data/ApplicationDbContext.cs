using Microsoft.EntityFrameworkCore;
using StuMSAPI.Models;

namespace StuMSAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Nick",
                    Dob = new DateOnly(1999, 12, 9),
                    Email = "nick@junkie.com"
                },
              new Student
              {
                  Id = 2,
                  Name = "Momo",
                  Dob = new DateOnly(2000, 12, 10),
                  Email = "momo@junkie.com"
              },
              new Student
              {
                  Id = 3,
                  Name = "Shem",
                  Dob = new DateOnly(2001, 12, 11),
                  Email = "shem@junkie.com"
              });
        }

    }
}
