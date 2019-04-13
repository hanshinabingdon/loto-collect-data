using Loto7.Models;

namespace Loto7.Controllers
{
    public class SevenController
    {
        public bool Get()
        {
            var html = HtmlGetter.GetFromUrl("http://sougaku.com/loto7/data/list1/");
            return true;
        }

        public bool Post()
        {
            return true;
        }
    }
}