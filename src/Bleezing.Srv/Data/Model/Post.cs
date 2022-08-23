using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Data.Model
{
    public class Post : Article
    {
        public Post()
        {
            base.Type = ArticleType.Post;
        }
        public Post(Article article)
        {
            base.Id = article.Id;
            base.Title = article.Title;
            base.Content = article.Content;
            base.CreatedAt = article.CreatedAt;
            base.LastModifiedAt = article.LastModifiedAt;
            base.Tags = article.Tags;
            base.Type = ArticleType.Post;
        }
        public MarkupString Html
        {
            get { return new MarkupString(Content); }
            set { Content = value.Value; }
        }
    }
}
