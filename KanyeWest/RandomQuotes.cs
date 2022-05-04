using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeWest
{
   public class RandomQuotes
    {
        public static void KQuote()
        {
            //create new instance of client
            var client = new HttpClient();
            //ref kanye URL
            var kanyeURL = "https://api.kanye.rest";
            // get request to return url from kanyeURL
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            //move through URL to find quotes
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye says {kanyeQuote}");
        }

        public static void RQuote()
        {
            var client = new HttpClient();
            //ref ron swanson URL
            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            // get request to return url from swansonURL
            var swansonResponse = client.GetStringAsync(swansonURL).Result;
            //move through URL to find quotes
            var ronQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron says {ronQuote}\n");
        }

    }
}
