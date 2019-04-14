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

            // 対象のテーブルは一つしかない
            var table = doc
                .GetElementsByClassName("bun_box2")
                .First()
                .GetElementsByTagName("tbody")
                .Single();

            // ヘッダを除いた当選情報を取得
            var data = table
                .GetElementsByTagName("tr")
                .Where(x => !(x.GetElementsByTagName("th").Any()));

            foreach (var tr in data)
            {
            }

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