using StuMSAPI.Data;
using StuMSAPI.Models;
using StuMSAPI.Repo.IRepo;

namespace StuMSAPI.Repo
{
    public class CourseRepo : Repo<Course>, ICourseRepo
    {
        private ApplicationDbContext _db;
        public CourseRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
