using System.Linq;
using AngleSharp.Html.Dom;
using Loto7.ViewModels;

namespace Loto7.Models
{
    public class HtmlAnalyzer
    {
        public HitData AnalyzeLotoSevenData(IHtmlDocument html)
        {
            // 対象のテーブルは一つしかない
            var table = html
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

            return new HitData(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
    }
}