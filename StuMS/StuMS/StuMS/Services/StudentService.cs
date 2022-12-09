using StuMS.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using StuMS.Services.IService;

namespace StuMS.Services
{
    public class StudentService : BaseService, IStudentService
    {
        private readonly IHttpClientFactory clientFactory;
        private string studentUrl;
        private IHttpClientFactory _clientFactory;

        public StudentService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            studentUrl = configuration.GetValue<string>("ServiceUrls:StudentApi");
            _clientFactory = clientFactory; 
        }

        public Task<T> CreateAsync<T>(StudentCreateDTO studentCreateDTO, IConfiguration configuration)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = Capstone_Utility.StaticDetails.APItype.POST,
                Data = studentCreateDTO,
                Url = studentUrl + "/api/students"


            });
        }

        public Task<T> CreateAsync<T>(StudentCreateDTO studentCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = Capstone_Utility.StaticDetails.APItype.DELETE,
                Url = studentUrl + "/api/students/" + id


            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = Capstone_Utility.StaticDetails.APItype.GET,
                Url = studentUrl + "/api/students"


            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = Capstone_Utility.StaticDetails.APItype.GET,
                Url = studentUrl + "/api/students/" + id


            });
        }

        public Task<T> UpdateAsync<T>(StudentUpdateDTO studentUpdateDTO)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                ApiType = Capstone_Utility.StaticDetails.APItype.PUT,
                Data = studentUpdateDTO,
                Url = studentUrl + "/api/students/" + studentUpdateDTO.Id


            });
        }
    }
}
