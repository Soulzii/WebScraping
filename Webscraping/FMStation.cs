using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webscraping
{
    class FMStation
    {
        public double MHz { get; private set; }
        public String Omroep { get; private set; }
        public String OmroepLocatie { get; private set; }

        public FMStation(double MHz, String Omroep, String OmroepLocatie)
        {
            this.MHz = MHz;
            this.Omroep = Omroep;
            this.OmroepLocatie = OmroepLocatie;
        }
    }
}
