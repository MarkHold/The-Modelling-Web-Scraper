using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace The_Modelling_Web_Scraper
{
    public class Scraper
    {
        public string init(string url)
        {
           string context = null; 
           
            using(WebClient client = new WebClient())
            {
                context = client.DownloadString(url);
                Console.WriteLine(context);
                Console.ReadKey();
            }

           return context;
        }

    }
}
