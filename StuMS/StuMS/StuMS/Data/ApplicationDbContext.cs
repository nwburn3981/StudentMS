using Microsoft.EntityFrameworkCore;
using StuMS.Models;

namespace StuMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
