using StuMS.Data;
using StuMS.Models;
using StuMS.Repo.IRepo;

namespace StuMS.Repo
{
    public class GradeRepo: Repo<Grade>, IGradeRepo
    {
        private readonly ApplicationDbContext _db;

        public GradeRepo(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}
