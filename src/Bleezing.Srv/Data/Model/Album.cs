namespace Bleezing.Srv.Data.Model
{
    public class Album : Article
    {
        public Album()
        {
            base.Type = ArticleType.Album;
        }
        public Album(Article article)
        {
            base.Id = article.Id;
            base.Title = article.Title;
            base.Content = article.Content;
            base.CreatedAt = article.CreatedAt;
            base.LastModifiedAt = article.LastModifiedAt;
            base.Tags = article.Tags;
            base.Type = ArticleType.Album;
        }

        public List<string> ImgSrcs
        {
            get
            { return Content.Split("$$").ToList(); }
            set
            {
                Content = string.Join("$$", value);
            }
        }
    }
}
