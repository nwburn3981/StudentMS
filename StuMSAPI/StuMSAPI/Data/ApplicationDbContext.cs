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

    }
}
