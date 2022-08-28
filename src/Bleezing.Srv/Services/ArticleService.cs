using Bleezing.Srv.Data;
using Bleezing.Srv.Data.Db;
using Bleezing.Srv.Data.Model;
using Bleezing.Srv.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Services
{
    public class ArticleService
    {
        private readonly ArticleContext context;

        public ArticleService(ArticleContext context)
        {
            this.context = context;
        }

        public async Task<Article> GetArticleByTitleAsync(string title)
        {
            var result = await context.articles!.FirstOrDefaultAsync(a => a.Title == title);
            if (result == null)
                return new MarkdownPost()
                {
                    Content = @"# Article Not Found
The requested article is not available."
                };
            else
            {
                switch(result.Type)
                {
                    case Article.ArticleType.Post: return new Post(result);
                    case Article.ArticleType.MarkdownPost: return new MarkdownPost(result);
                    case Article.ArticleType.Album: return new Album(result);
                    case Article.ArticleType.MediaPost: return new MediaPost(result);
                }
                return result;
            }
        }

        public async Task<List<Article>> GetArticlesPageAsync(int count, int pos)
        {
            var nextPage = await context.articles!
                .OrderByDescending(a => a.CreatedAt)
                .Skip(pos)
                .Take(count)
                .ToListAsync();
            return nextPage;
        }

        public int GetArticleCount()
        {
            return context.articles!.Count();
        }
    }
}
