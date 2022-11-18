using StuMS.Data;
using StuMS.Models;
using StuMS.Repo.IRepo;

namespace StuMS.Repo
{
    public class TeacherRepo: Repo<Teacher>, ITeacherRepo
    {
        private readonly ApplicationDbContext _db;

        public TeacherRepo(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}
