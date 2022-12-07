using StuMSAPI.Data;
using StuMSAPI.Models;
using StuMSAPI.Repo.IRepo;

namespace StuMSAPI.Repo
{
    public class StudentRepo: Repo<Student>, IStudentRepo
    {
        private ApplicationDbContext _db;
        public StudentRepo(ApplicationDbContext db): base(db)   
        {
            _db = db;
        }

    }
}
