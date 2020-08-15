namespace FileMapper.FileModels
{
    public class PdfIssueModel : IIssuable
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Status { get; set; }
    }
}
