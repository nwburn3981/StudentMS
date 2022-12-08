using CapstoneAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }


        //Initializing for many to * relationship seeding
        static Student nick = new Student
        {
            Id = 1,
            Name = "Nick Dude",
            dateOfBirth = new DateTime(1991, 01, 14)
        };

        static Student momo = new Student
        {
            Id = 2,
            Name = "Momo Guy",
            dateOfBirth = new DateTime(2010, 11, 18)
        };

        static Student shem = new Student
        {
            Id = 3,
            Name = "Shem Bud",
            dateOfBirth = new DateTime(1997, 05, 06)
        };

        static Teacher jeff = new Teacher
        {
            Id = 1,
            Name = "Jeff Lowe"
        };

        static Teacher leff = new Teacher
        {
            Id = 2,
            Name = "Leff Jowe"
        };

        static Course yoga = new Course
        {
            Id = 1,
            Name = "Yoga 506",
            TeacherId = leff.Id
        };

        static Course hydro = new Course
        {
            Id = 2,
            Name = "Advanced Hydrophysics",
            TeacherId = leff.Id
        };

        static Course beekeeping = new Course
        {
            Id = 3,
            Name = "Beekeeping 101",
            TeacherId = jeff.Id
        };

        static Course beelosing = new Course
        {
            Id = 4,
            Name = "Beelosing 101",
            TeacherId = jeff.Id
        };


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                nick,
                momo,
                shem
                );

            modelBuilder.Entity<Teacher>().HasData(
                jeff,
                leff
                );

            modelBuilder.Entity<Course>().HasData(
                yoga,
                hydro,
                beekeeping,
                beelosing
                );

            modelBuilder.Entity<Grade>().HasData(
                new Grade
                {
                    Id = 1,
                    LetterGrade = "A",
                    StudentId = nick.Id,
                    CourseId = yoga.Id
                },
                new Grade
                {
                    Id = 2,
                    LetterGrade = "A",
                    StudentId = nick.Id,
                    CourseId = beekeeping.Id
                },
                new Grade
                {
                    Id = 3,
                    LetterGrade = "A",
                    StudentId = momo.Id,
                    CourseId = hydro.Id
                },
                new Grade
                {
                    Id = 4,
                    LetterGrade = "A",
                    StudentId = momo.Id,
                    CourseId = beelosing.Id
                },
                new Grade
                {
                    Id = 5,
                    LetterGrade = "A",
                    StudentId = shem.Id,
                    CourseId = beekeeping.Id
                },
                new Grade
                {
                    Id = 6,
                    LetterGrade = "A",
                    StudentId = shem.Id,
                    CourseId = beelosing.Id
                }
                );


        }

    }
}
