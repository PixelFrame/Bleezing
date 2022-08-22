using Microsoft.AspNetCore.Components;

namespace Bleezing.Srv.Data.Model
{
    public class Post : Article
    {
        public MarkupString Html
        {
            get { return new MarkupString(Content); }
            set { Content = value.Value; }
        }
    }
}
