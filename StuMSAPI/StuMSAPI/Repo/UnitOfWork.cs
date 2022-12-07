using StuMSAPI.Data;
using StuMSAPI.Repo.IRepo;

namespace StuMSAPI.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IStudentRepo Student { get; private set; }

        public ICourseRepo Course { get; private set; }

        public ITeacherRepo Teacher { get; private set; }

        public IGradeRepo Grade { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Student = new StudentRepo(_db);
            Course = new CourseRepo(_db);
            Teacher = new TeacherRepo(_db);
            Grade = new GradeRepo(_db);
        }

        void IUnitOfWork.Save()
        {
            _db.SaveChanges();
        }
    }
}
