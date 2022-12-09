using StuMS.Models.Dto;


namespace StuMS.Services.IService
{
    public interface IStudentService
    {
        Task<T> GetAllAsync<T>();

        Task<T> GetAsync<T>(int id);

        Task<T> CreateAsync<T>(StudentCreateDTO studentCreateDTO);

        Task<T> UpdateAsync<T>(StudentUpdateDTO studentUpdateDTO);

        Task<T> DeleteAsync<T>(int id);


    }
}
