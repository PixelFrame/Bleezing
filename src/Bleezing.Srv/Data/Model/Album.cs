namespace Bleezing.Srv.Data.Model
{
    public class Album : Article
    {
        public List<string> ImgSrcs { get
            { return Content.Split("$$").ToList(); }
            set 
            {
                Content = string.Join("$$", value);
            }
        }
    }
}
