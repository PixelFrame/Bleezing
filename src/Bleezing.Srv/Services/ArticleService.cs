using Bleezing.Srv.Data;
using Bleezing.Srv.Data.Model;
using Bleezing.Srv.Shared;
using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Services
{
    public class ArticleService
    {
        public async Task<IArticle> GetArticleByTitleAsync(string title)
        {
            return new MarkdownPost()
            {
                Content = @"# Article Not Found
The requested article is not available."
            };
        }
    }
}
