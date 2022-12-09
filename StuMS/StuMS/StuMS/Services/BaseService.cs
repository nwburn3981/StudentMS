using StuMS.Models;
using Newtonsoft.Json;
using StuMS.Models;
using StuMS.Services.IService;
using System.Text;
using NPOI.XWPF.UserModel;

namespace StuMS.Services
{
    public class BaseService : IBaseInterface
    {
        public APIResponse responseModel { get; set; }

        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.httpClient = httpClient;
            this.responseModel = new();
        }

        public async Task<T> SendAsync<T>(APIRequest request)
        {
            var client = httpClient.CreateClient("CapstoneAPI");

            HttpRequestMessage message = new HttpRequestMessage();

            message.Headers.Add("Accept", "application/json");

            message.RequestUri = new Uri(request.Url);
            
            if (request.Data != null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(request.Data), Encoding.UTF8, "application/json");
            }

            switch (request.ApiType)
            {
                case Capstone_Utility.StaticDetails.APItype.POST:
                    message.Method = HttpMethod.Post;
                    break;

                case Capstone_Utility.StaticDetails.APItype.PUT:
                    message.Method = HttpMethod.Put;
                    break;

                case Capstone_Utility.StaticDetails.APItype.DELETE:
                    message.Method = HttpMethod.Delete;
                    break;
                default:
                    message.Method = HttpMethod.Get;
                    break;

            }

            HttpResponseMessage apiResponse = null;

            apiResponse = await client.SendAsync(message);

            var apiContent = await apiResponse.Content.ReadAsStringAsync();

            try
            {
                APIResponse ApiResponse = JsonConvert.DeserializeObject<APIResponse>(apiContent);

                if (ApiResponse != null && (apiResponse.StatusCode == System.Net.HttpStatusCode.BadRequest 
                    || apiResponse.StatusCode == System.Net.HttpStatusCode.NotFound))
                {
                    ApiResponse.StatusCode= System.Net.HttpStatusCode.BadRequest;
                    ApiResponse.IsSuccess= false;
                    var res = JsonConvert.SerializeObject(ApiResponse);
                    var returnObj = JsonConvert.DeserializeObject<T>(res);

                    return returnObj;
                }
            } catch (Exception ex)
            {
                var exceptionResponse = JsonConvert.DeserializeObject<T>(apiContent);
                return exceptionResponse;
            }

            var APIResponse = JsonConvert.DeserializeObject<T>(apiContent);
            return APIResponse;
        }
    }
}
