namespace Bleezing.Srv.Data.Model
{
    public class MediaPost : Article
    {
        public MediaPost()
        {
            base.Type = ArticleType.MediaPost;
        }
        public MediaPost(Article article)
        {
            base.Id = article.Id;
            base.Title = article.Title;
            base.Content = article.Content;
            base.CreatedAt = article.CreatedAt;
            base.LastModifiedAt = article.LastModifiedAt;
            base.Tags = article.Tags;
            base.Type = ArticleType.MediaPost;
        }
        public string Src
        {
            get { return Content[..Content.IndexOf('$')]; }
        }

        public string Uri
        {
            get { return Content[(Content.IndexOf('$') + 1)..]; }
        }
    }
}
