using StuMS.Models;
using StuMS.Models;

namespace StuMS.Services.IService
{
    public interface IBaseInterface
    {

        APIResponse responseModel { get; set; }

        Task<T> SendAsync<T>(APIRequest request);
    }
}
