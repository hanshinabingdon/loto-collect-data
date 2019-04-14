using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace Loto7.Models
{
    public class HtmlGetter
    {
        public static IHtmlDocument GetFromUrl(string url)
        {
            var doc = Get(url).Result;
            return doc;
        }

        /// <summary>
        /// html取得実態
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static async Task<IHtmlDocument> Get(string url)
        {
            using (var client = new HttpClient())
            using (var stream = await client.GetStreamAsync(new Uri(url)))
            {
                var parser = new HtmlParser();
                return await parser.ParseDocumentAsync(stream);
            }
        }
    }
}