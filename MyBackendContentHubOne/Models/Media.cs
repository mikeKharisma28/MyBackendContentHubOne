namespace MyBackendContentHubOne.Models
{
    public class MediaResults
    {
        public List<Media>? results { get; set; }
    }

    public class Media
    {
        public string? id { get; set; }

        public string? name { get; set; }

        public string? fileName { get; set; }

        public string? fileUrl { get; set; }

        public string? description { get; set; }

        public decimal fileWidth { get; set; }

        public decimal fileHeight { get; set; }

        public string? fileId { get; set; }

        public decimal fileSize { get; set; }

        public string? fileType { get; set; }
    }
}
