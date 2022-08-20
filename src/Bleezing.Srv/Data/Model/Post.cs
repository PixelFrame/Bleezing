using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Data.Model
{
    public class Post : IArticle
    {
        public string Title { get; set; } = "New Post";
        public List<string> Tags { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedAt { get; set; } = DateTime.Now;
        public MarkupString Content { get; set; }
        object? IArticle.Content { get; set; }
    }
}
