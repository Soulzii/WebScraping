using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webscraping
{
    class WebScraper
    {

        public static WebScraper instance;

        public List<FMStation> GetListOfStationsByUrl(String url)
        {
            return null;
        }

        public List<FMStation> GetListOfStations()
        {
            List<FMStation> stations = new List<FMStation>();
            String location = "http://www.radiofreak.nl/frequenties";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlWeb().Load(location);
            int count = 0;
            String MHz = "";
            String zender = "";
            String locatie = "";
            int i = 0;
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//tr"))
            {
                if (count >= 1)
                {
                    foreach (HtmlNode link2 in link.SelectNodes("td"))
                    {
                        switch (i)
                        {
                            case 0:
                                MHz = link2.InnerText;
                                break;
                            case 1:
                                zender = link2.InnerText;
                                break;
                            case 2:
                                locatie = link2.InnerText;
                                break;
                            case 3:
                                stations.Add(new FMStation(MHz, zender, locatie));
                                break;
                        }
                        i++;
                    }
                    i = 0;
                }
                count++;
                if (count == 6)
                {
                    return stations;
                }
            }
            return null;
        }
    }
}
