namespace StuMSAPI.Repo.IRepo
{
    public interface IUnitOfWork
    {

        IStudentRepo Student { get; }
        ICourseRepo Course { get; }
        ITeacherRepo Teacher { get; }
        IGradeRepo Grade { get; }

        void Save();

    }
}
