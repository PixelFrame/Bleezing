using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bleezing.Srv.Data.Model
{
    public class Article : IArticle
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = "New Article";
        public List<string> Tags { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedAt { get; set; } = DateTime.Now;
        [Required]
        public string Content { get; set; } = "No Content";

        public ArticleType Type = 0;

        public enum ArticleType
        {
            Post = 0,
            MarkdownPost = 1,
            Album = 2,
            MediaPost = 3
        }
    }
}
