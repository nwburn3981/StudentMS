using Capstone_Utility;
using static Capstone_Utility.StaticDetails;


namespace StuMS.Models
{
    public class APIRequest
    {
        public APItype ApiType { get; set; } = APItype.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }
    }
}