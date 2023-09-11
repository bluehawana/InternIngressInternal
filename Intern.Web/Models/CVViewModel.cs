namespace InternIngressInternal.Intern.Web.Models
{
    public class CVViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}