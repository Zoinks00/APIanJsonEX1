using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            //for statement that counts to 10 
            //new  randomly picked kenya quotes for every even number
            //new randomly picked ron quotes for every odd number.
            for(int i =0; i <10; i++)
            {
                if(i %2 ==0 )
                {
                    RandomQuotes.KQuote();
                }
                else //if (i % 2 != 0)
                {
                    RandomQuotes.RQuote();
                }
            }//end for
        }//end main
    }
}
