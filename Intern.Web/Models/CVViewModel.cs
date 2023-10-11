namespace InternIngressInternal.Intern.Web.Models
{
    public class CVViewModel
    {
        public string? RequestId { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        IFileHttpResult fileHttpResult = new FileHttpResult();  
        public IFileHttpResult FileHttpResult { get => fileHttpResult; set => fileHttpResult = value; }
        public CVViewModel() { }
        public CVViewModel(IFileHttpResult fileHttpResult)
        {
            FileHttpResult = fileHttpResult;
        }
        public CVViewModel(CVViewModel cvViewModel)
        {
                
        }
    }
}