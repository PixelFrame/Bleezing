using Bleezing.Srv.Data;
using Bleezing.Srv.Data.Model;
using Bleezing.Srv.Shared;
using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Services
{
    public class ArticleRenderService
    {
        public async Task<RenderFragment> Render(string title)
        {
            var article = await GetArticleAsync(title);
            if(article is MarkdownPost mdpost) { }
            return new RenderFragment(builder => { });
        }

        private async Task<IArticle> GetArticleAsync(string title)
        {
            return new Post();
        }
    }
}
