namespace Bleezing.Srv.Data.Model
{
    public class MediaPost : IArticle
    {
        public string Title { get; set; } = "New Media Post";
        public List<string> Tags { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedAt { get; set; } = DateTime.Now;
        public string Content { get; set; } = string.Empty;
        object? IArticle.Content { get; set; }
    }
}
