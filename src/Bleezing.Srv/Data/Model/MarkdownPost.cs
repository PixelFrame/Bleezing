namespace Bleezing.Srv.Data.Model
{
    public class MarkdownPost : Article
    {
        public string RawMarkdown
        {
            get { return Content; }
            set { Content = value; }
        }
    }
}
