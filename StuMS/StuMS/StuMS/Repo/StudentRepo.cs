using StuMS.Data;
using StuMS.Models;
using StuMS.Repo.IRepo;

namespace StuMS.Repo
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
