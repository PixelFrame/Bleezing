using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Data.Model
{
    public interface IArticle
    {
        public string Title { get; set; }
        public List<string> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public object? Content { get; set; }
    }
}
