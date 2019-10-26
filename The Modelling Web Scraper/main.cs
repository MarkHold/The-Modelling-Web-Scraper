using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Modelling_Web_Scraper
{
    class main
    {
        static void Main(string[] args)
        {
            Scraper scraper = new Scraper();
            
            scraper.init("https://www.alphavantage.co/query?function=SMA&symbol=MSFT&interval=weekly&time_period=10&series_type=open&apikey=demo");
            
        }
    }
}
