namespace Bleezing.Srv.Data.Model
{
    public class MarkdownPost : IArticle
    {
        public string Title { get; set; } = "New Markdown Post";
        public List<string> Tags { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedAt { get; set; } = DateTime.Now;
        public string Content { get; set; } = "# New Markdown Post";
        object? IArticle.Content { get; set; }
    }
}
