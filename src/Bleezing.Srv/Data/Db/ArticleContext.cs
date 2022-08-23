using Bleezing.Srv.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bleezing.Srv.Data.Db
{
    public class ArticleContext : DbContext
    {
        public static readonly string RowVersion = nameof(RowVersion);
        public static readonly string ArticlesDb = nameof(ArticlesDb).ToLower();

        public ArticleContext(DbContextOptions<ArticleContext> options)
            : base(options)
        {
            Debug.WriteLine($"{ContextId} context created.");
        }
        
        public DbSet<Article>? articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property<byte[]>(RowVersion)
                .IsRowVersion();

            modelBuilder.Entity<Article>()
                .Property(e => e.Tags)
                .HasConversion(
                        v => string.Join(',', v),
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() ?? new List<string>());

            modelBuilder.Entity<Article>()
                .Property(e => e.Type)
                .HasConversion<int>();

            base.OnModelCreating(modelBuilder);
        }

        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }
    }
}
