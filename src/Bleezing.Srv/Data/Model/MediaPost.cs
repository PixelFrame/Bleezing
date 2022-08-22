namespace Bleezing.Srv.Data.Model
{
    public class MediaPost : Article
    {
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
