using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Data.Model
{
    public class Album : IArticle
    {
        public string Title { get; set; } = "New Album";
        public List<string> Tags { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedAt { get; set; } = DateTime.Now;
        public List<string> Content { get; set; } = new();
        object? IArticle.Content { get; set; }
    }
}
