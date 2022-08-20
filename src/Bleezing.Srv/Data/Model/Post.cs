using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Data.Model
{
    public class Post : IArticle
    {
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Tags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime LastModifiedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MarkupString Content { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        object IArticle.Content { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
