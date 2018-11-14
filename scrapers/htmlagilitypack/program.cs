using System;
using System.Net.Http;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

namespace WebScraper
{
    class MainClass
    {
        static void Main(string[] args)
        {

            GetJsonAsync();
            Console.ReadLine();
        }

        private static async void GetJsonAsync()
        {
            Console.WriteLine("Enter symbol you would like stock info from: ");
            var symbol = Console.ReadLine();
            
            UriBuilder builderUrl = new UriBuilder("https", "query1.finance.yahoo.com")
            {
                Path = "v7/finance/quote",
                Query = "?symbols=" + symbol
            };
            string finalUrl = builderUrl.ToString();

            Console.WriteLine(finalUrl);

            //Uri url = new Uri("https://query1.finance.yahoo.com/v7/finance/quote?symbols=amzn");

            //var url = "https://query1.finance.yahoo.com/v7/finance/quote?symbols=amzn";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(finalUrl);
            JObject json = JObject.Parse(html);

            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            Console.WriteLine(json);
        }
    }
}
