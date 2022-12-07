using StuMSAPI.Data;
using StuMSAPI.Models;
using StuMSAPI.Repo.IRepo;

namespace StuMSAPI.Repo
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
