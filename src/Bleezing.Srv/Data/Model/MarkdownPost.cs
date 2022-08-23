namespace Bleezing.Srv.Data.Model
{
    public class MarkdownPost : Article
    {
        public MarkdownPost()
        {
            base.Type = ArticleType.MarkdownPost;
        }
        public MarkdownPost(Article article)
        {
            base.Id = article.Id;
            base.Title = article.Title;
            base.Content = article.Content;
            base.CreatedAt = article.CreatedAt;
            base.LastModifiedAt = article.LastModifiedAt;
            base.Tags = article.Tags;
            base.Type = ArticleType.MarkdownPost;
        }
        public string RawMarkdown
        {
            get { return Content; }
            set { Content = value; }
        }
    }
}
