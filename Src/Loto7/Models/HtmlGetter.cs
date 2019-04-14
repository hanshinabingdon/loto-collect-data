using System;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace Loto7.Models
{
    public class HtmlGetter
    {
        /// <summary>
        /// 指定されたURLからHTMLを取得する
        /// </summary>
        /// <param name="url">対象URL</param>
        /// <returns>HTML</returns>
        public static IHtmlDocument GetFromUrl(string url)
        {
            return Get(url).Result;
        }

        /// <summary>
        /// html取得実態
        /// </summary>
        /// <param name="url">対象URL</param>
        /// <returns>html取得タスク</returns>
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