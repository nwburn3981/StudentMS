namespace StuMS.Models
{
    public class ErrorViewMode
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}