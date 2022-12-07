using StuMSAPI.Data;
using StuMSAPI.Models;
using StuMSAPI.Repo.IRepo;

namespace StuMSAPI.Repo
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
